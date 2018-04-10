using System;
using System.Collections.Generic;
using System.IO;
using Gameloop.Vdf;

namespace SteamPipeGUI.NET
{
    public class Depot
    {
        public int DepotId { get; set; }

        public string ContentRoot { get; set; } = ".";

        public List<FileMapping> FileMappings { get; set; } = new List<FileMapping>();

        public List<FileExclusion> FileExclusions { get; set; } = new List<FileExclusion>();

        public Depot(int depotId)
        {
            DepotId = depotId;
            FileMappings.Add(new FileMapping());
            FileExclusions.Add(new FileExclusion());
        }

        public Depot(string path)
        {
            Parse(path);
        }

        public override string ToString()
        {
            return
                $"\"DepotBuildConfig\"\n{{{Environment.NewLine} \"DepotID\" \"{DepotId}\"{Environment.NewLine} \"ContentRoot\" \"{ContentRoot}\"{Environment.NewLine}{Environment.NewLine}{string.Join(Environment.NewLine + Environment.NewLine, FileMappings)} {Environment.NewLine}{Environment.NewLine} {string.Join(Environment.NewLine, FileExclusions)}{Environment.NewLine}}}";
        }

        private void Parse(string path)
        {
            VObject vObject = (VObject) VdfConvert.Deserialize(File.ReadAllText(path).Replace(@"\", @"\\")).Value;
            DepotId = int.Parse(vObject["DepotID"].ToString());
            ContentRoot = vObject["ContentRoot"].ToString();
            foreach (VProperty child in vObject.Children()) {
                switch (child.Key) {
                    case "FileMapping":
                        VObject mapping = (VObject) child.Value;
                        FileMappings.Add(new FileMapping {
                            LocalPath = mapping["LocalPath"].ToString(),
                            DepotPath = mapping["DepotPath"].ToString(),
                            Recursive = int.Parse(mapping["recursive"].ToString())
                        });
                        break;
                    case "FileExclusion":
                        FileExclusions.Add(new FileExclusion(child.Value.ToString()));
                        break;
                    default:
                        continue;
                }
            }
        }
    }

    public class FileMapping
    {
        public string LocalPath { get; set; }

        public string DepotPath { get; set; }

        public int Recursive { get; set; }

        public FileMapping()
        {
            LocalPath = DepotPath = ".";
            Recursive = 1;
        }

        public override string ToString()
        {
            return
                $" \"FileMapping\"{Environment.NewLine} {{{Environment.NewLine}  \"LocalPath\" \"{LocalPath}\"{Environment.NewLine}  \"DepotPath\" \"{DepotPath}\"{Environment.NewLine}  \"recursive\" \"{Recursive}\"{Environment.NewLine} }}";
        }
    }

    public class FileExclusion
    {
        public string Pattern { get; set; }

        public FileExclusion()
        {
            Pattern = "*.pdb";
        }

        public FileExclusion(string pattern)
        {
            Pattern = pattern;
        }

        public override string ToString()
        {
            return
                $"\"FileExclusion\" \"{Pattern}\"";
        }
    }
}
