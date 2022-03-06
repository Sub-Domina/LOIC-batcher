namespace LOIC_Batcher
{
    public class BatchSetting
    {
        public string Threads { get; set; } = "40";
        public string Sockets { get; set; } = "100";
        public string Delay { get; set; } = "10";
        public bool Hidden { get; set; } = false;
    }
}
