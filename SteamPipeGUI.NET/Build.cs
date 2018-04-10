using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Gameloop.Vdf;

namespace SteamPipeGUI.NET
{
    public class Build
    {
        public int AppId { get; set; } = 480;

        public string BuildDescription { get; set; } = "null";

        public string BuildOutput { get; set; } = @"..\output\";

        public string ContentRoot { get; set; } = @"..\content\";

        public string SetLive { get; set; } = string.Empty;

        public bool Preview { get; set; }

        private string _preview => Preview ? "1" : "0";

        public string Local { get; set; } = string.Empty;

        public List<string> Depots { get; set; } = new List<string>();

        public Build(int appid)
        {
            AppId = appid;
        }

        public Build(string path)
        {
            Parse(path);
        }

        private void Parse(string path)
        {
            VObject vObject = (VObject) VdfConvert.Deserialize(File.ReadAllText(path).Replace(@"\", @"\\")).Value;
            AppId = int.Parse(vObject["appid"].ToString());
            BuildDescription = vObject["desc"].ToString();
            BuildOutput = vObject["buildoutput"].ToString();
            ContentRoot = vObject["contentroot"].ToString();
            SetLive = vObject["setlive"].ToString();
            Preview = vObject["preview"].ToString() == "1";
            Local = vObject["local"].ToString();
        }

        public override string ToString()
        {
            return $@"""appbuild""
{{
    ""appid"" ""{AppId}""
    ""desc"" ""{BuildDescription}""
    ""buildoutput"" ""{BuildOutput}""
    ""contentroot"" ""{ContentRoot}""
    ""setlive"" ""{SetLive}""
    ""preview"" ""{_preview}""
    ""local"" ""{Local}""

    ""depots""
    {{
{string.Concat(
                Depots.Select(
                    x =>
                        string.Format(@"            ""{0}"" ""depot_build_{0}.vdf""{1}", x,
                            Depots.IndexOf(x) != Depots.Count - 1 ? Environment.NewLine : string.Empty)))}
    }}
}}";
        }
    }
}
