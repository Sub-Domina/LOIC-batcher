using System.Text.Json.Serialization;

namespace LOIC_Batcher
{
    public class SaveData
    {
        public GlobalSetting? GlobalSetting { get; set; }
        public BatchSetting? BatchSetting { get; set; }
        public TargetCollection? TargetsCollection { get; set; }
    }
}
