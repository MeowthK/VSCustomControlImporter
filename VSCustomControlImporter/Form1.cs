using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VSCustomControlImporter
{
    public partial class VSCCImporter : Form
    {
        private string solutionName = string.Empty;
        private string customControlName = string.Empty;
        private bool hasResx = true;

        private const string NAMESPACESTR = "namespace";
        private string[] RESERVEDCS =
        {
            "Program.cs",
            "AssemblyInfo.cs",
            "Resources.Designer.cs",
            "Settings.Designer.cs"
        };

        public VSCCImporter()
        {
            InitializeComponent();

            this.Load += RegisterEvents;
        }

        private void RegisterEvents( object sender, EventArgs e )
        {
            btnCCLoc.Click += GetCCLocation;
            btnProjLoc.Click += GetProjLocation;
            btnDCCLoc.Click += GetDestCCLocation;
            btnProceed.Click += ProcessCCFiles;

            btnGotoProjLoc.Click += ( obj, ev ) =>
            {
                var process = new System.Diagnostics.
                    ProcessStartInfo( "explorer.exe", tbProjLoc.Text );
                System.Diagnostics.Process.Start( process );
            };

            tbCCLoc.TextChanged += ( obj, ev ) =>
            {
                btnProceed.Enabled = tbCCLoc.TextLength > 0 && tbProjLoc.TextLength > 0;
            };

            tbProjLoc.TextChanged += ( obj, ev ) =>
            {
                btnProceed.Enabled = tbCCLoc.TextLength > 0 && tbProjLoc.TextLength > 0;
                btnGotoProjLoc.Enabled = tbProjLoc.Text != string.Empty;
            };
        }

        private void GetCCLocation( object sender, EventArgs e )
        {
            using ( OpenFileDialog ofd = new OpenFileDialog() )
            {
                ofd.FileOk +=( obj, ev )=>
                {
                    foreach ( var reserved in RESERVEDCS )
                    {
                        if ( System.IO.Path.GetFileName( ofd.FileName ) == reserved )
                        {
                            MessageBox.Show( reserved + " cannot be imported!" );
                            return;
                        }
                    }

                    tbCCLoc.Text = ofd.FileName;
                    customControlName = System.IO.Path.GetFileName( tbCCLoc.Text ).Replace( ".Designer", "" ).Replace( ".cs", "" );
                };

                ofd.Filter = "C# Files|*.cs";
                ofd.ShowDialog();
            }
        }

        private void GetProjLocation( object sender, EventArgs e )
        {
            using ( FolderBrowserDialog fbd = new FolderBrowserDialog() )
            {
                fbd.Description = "Select the Project's Root Folder";
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                fbd.ShowNewFolderButton = false;
                fbd.ShowDialog();

                if ( fbd.SelectedPath != string.Empty )
                {
                    string[] files = System.IO.Directory.GetFiles( fbd.SelectedPath );

                    foreach ( string file in files )
                    {
                        if ( file.Replace( ".sln", "" ).Length < file.Length )
                        {
                            tbProjLoc.Text = fbd.SelectedPath;
                            solutionName = System.IO.Path.GetFileName( file ).Replace( ".sln", "" );
                            tbDCCLoc.Text = fbd.SelectedPath + "\\" + solutionName;
                            return;
                        }
                    }

                    MessageBox.Show( "Project folder selected is not valid." );
                }
            }
        }

        private void GetDestCCLocation( object sender, EventArgs e )
        {
            using ( FolderBrowserDialog fbd = new FolderBrowserDialog() )
            {
                fbd.Description = "Select where you want your custom control to be copied to";
                fbd.RootFolder = Environment.SpecialFolder.MyComputer;
                fbd.SelectedPath = tbProjLoc.Text + "\\" + solutionName;
                fbd.ShowDialog();

                if ( System.IO.Directory.Exists( fbd.SelectedPath ) && tbProjLoc.TextLength > 0 && fbd.SelectedPath.Replace( tbProjLoc.Text + "\\" + solutionName, "" ).Length < fbd.SelectedPath.Length )
                    tbDCCLoc.Text = fbd.SelectedPath;
            }
        }

        private void ProcessCCFiles( object sender, EventArgs e )
        {
            string fname = System.IO.Path.GetDirectoryName( tbCCLoc.Text );
            string[] files = System.IO.Directory.GetFiles( fname );

            const int CS = 0;
            const int DESIGNER = 1;
            const int RESX = 2;

            string[] cccontents = new string[ 3 ];
            string[] ccfiles =
            {
                customControlName + ".cs",
                customControlName + ".Designer.cs",
                customControlName + ".resx"
            };

            for ( int i = 0; i < ccfiles.Length; i++ )
            {
                foreach ( string file in files )
                {
                    if ( System.IO.Path.GetFileName( file ) == ccfiles[ i ] )
                    {
                        cccontents[ i ] = System.IO.File.ReadAllText( file );
                        break;
                    }
                }
            }

            // do some file altering tricks here...
            // and transfer it to destination project folder

            /*
             * 1. If no .Designer.cs found, assume that file is a basic class
             *    Do not proceed to No. 2
             * 2. Scan file .cs and check its type whether:
             *    UserControl, Form, etc.
             * 3. Copy .cs/.Desginer.cs/.resx files into the project folder.
             * 4. Alter project folder's .csproj contents
             *    - Add <SomeTags here>BLABLA.cs</SomeTagsHere>
             * 5. Sleep.
             */

            cccontents[ CS ] = ReplaceNamespace( cccontents[ CS ] );

            if ( cccontents[ DESIGNER ] != null )
                cccontents[ DESIGNER ] = ReplaceNamespace( cccontents[ DESIGNER ] );

            hasResx = cccontents[ RESX ] != null;

            string itemGroupCTag = "</ItemGroup>";
            string csprojContents = System.IO.File.ReadAllText( tbProjLoc.Text + "\\" + solutionName + "\\" + solutionName + ".csproj" );
            int startIndex = csprojContents.IndexOf( itemGroupCTag ) + itemGroupCTag.Length;
            int endIndex = startIndex;

            while ( csprojContents[ endIndex ] != '>' && endIndex < csprojContents.Length )
                endIndex++;

            string classType = GetClassType( cccontents[ CS ] );
            csprojContents = csprojContents.Insert( endIndex + 1, GetProjectIncludeTag( classType ) );

            if ( MessageBox.Show( "Are you sure you want to import " + ccfiles[ CS ] + "?\r\nThese cannot be undone.", "Confirm Overwrite", MessageBoxButtons.YesNo ) == System.Windows.Forms.DialogResult.Yes )
            {
                System.IO.File.WriteAllText( tbDCCLoc.Text + "\\" + ccfiles[ CS ], cccontents[ CS ] );

                if ( cccontents[ DESIGNER ] != null )
                    System.IO.File.WriteAllText( tbDCCLoc.Text + "\\" + ccfiles[ DESIGNER ], cccontents[ DESIGNER ] );

                if ( cccontents[ RESX ] != null )
                    System.IO.File.WriteAllText( tbDCCLoc.Text + "\\" + ccfiles[ RESX ], cccontents[ RESX ] );

                System.IO.File.WriteAllText( tbProjLoc.Text + "\\" + solutionName + "\\" + solutionName + ".csproj", csprojContents );

                MessageBox.Show( "Import Done." );
            }
        }

        private string GetClassType( string contents )
        {
            int startIndex = contents.IndexOf( customControlName + " : " );

            if ( startIndex == -1 )
                return "Basic Class";

            startIndex += ( customControlName + " : " ).Length;
            int endIndex = startIndex;

            while ( contents[ endIndex ] != '{' && endIndex < contents.Length )
                endIndex++;

            return contents.Substring( startIndex, endIndex - startIndex - 1 ).Trim();
        }

        private string GetProjectIncludeResxTag()
        {
            //<EmbeddedResource Include="Form1.resx">
            //  <DependentUpon>Form1.cs</DependentUpon>
            //</EmbeddedResource>

            string relativePath = GetRelativePath();

            string resxTag = "\n" +
                "    <EmbeddedResource Include=\"" + relativePath + customControlName + ".resx\">\n" +
                "      <DependentUpon>" + customControlName + ".cs</DependentUpon>\n" +
                "    </EmbeddedResource>";

            return resxTag;
        }

        private string GetRelativePath()
        {
            string solutionPath = tbProjLoc.Text + "\\" + solutionName;
            string relativePath = tbDCCLoc.Text.Replace( solutionPath, "" );

            if ( relativePath.Length > 0 )
                relativePath = relativePath.Substring( 1 ) + "\\";

            return relativePath;
        }

        private string GetProjectIncludeTag( string classType )
        {
            string relativePath = GetRelativePath();

            string includeTag = "\n" +
                    "    <Compile Include=\"" + relativePath + customControlName + ".cs\">\n";

            if ( classType != "Basic Class" )
            {
                includeTag +=
                    "      <SubType>" + classType + "</SubType>\n" +
                    "    </Compile>\n" +
                    "    <Compile Include=\"" + relativePath + customControlName + ".Designer.cs\">\n" +
                    "      <DependentUpon>" + customControlName + ".cs</DependentUpon>\n";
            }

            includeTag +=
                    "    </Compile>";

            if ( hasResx )
                includeTag += GetProjectIncludeResxTag();

            return includeTag;
        }

        private string ReplaceNamespace( string code )
        {
            int startIndex = code.IndexOf( NAMESPACESTR ) + NAMESPACESTR.Length;
            int endIndex = startIndex;

            while ( code[ endIndex ] != '\n' && endIndex < code.Length )
                endIndex++;

            code = code.Remove( startIndex, endIndex - startIndex );
            code = code.Insert( startIndex, " " + solutionName );

            return code;
        }
    }
}
