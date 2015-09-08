﻿using System.Collections.Generic;
using System.Xml.Serialization;

namespace WitcherScriptMerger.Inventory
{
    [XmlRoot]
    public class MergedScript
    {
        [XmlElement]
        public string RelativePath;

        [XmlElement]
        public string MergedModName;

        [XmlElement(ElementName="ModBackup")]
        public List<string> ModBackups;
    }
}
