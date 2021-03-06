using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V9_0_1_36216.Hotfix
{
    [HotfixStructure(DB2Hash.NamesReserved, HasIndexInData = false)]
    public class NamesReservedEntry
    {
        public string Name { get; set; }
    }
}
