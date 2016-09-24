// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

namespace Wangkanai.Detection
{
    public class Browser
    {
        public string Name { get; set; }
        public string Maker { get; set; }
        public BrowserType Type { get; set; }
        public byte Bits { get; set; }
        public string Version { get; set; }
        public Feature Feature { get; set; }
    }
}