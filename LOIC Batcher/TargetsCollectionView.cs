namespace LOIC_Batcher
{
    internal class TargetsCollectionView
    {
        private TargetView?[] targets;

        public TargetsCollectionView()
        {
            targets = new TargetView[0];
        }

        public TargetsCollectionView(Panel targetsPanel, IPTarget[]? targets)
        {
            if (targets == null)
            {
                this.targets = new TargetView[0];
                return;
            }
            this.targets = new TargetView[targets.Length];
            for (int i = 0; i < targets.Length; i++)
            {
                this.targets[i] = new TargetView(i, targetsPanel, targets[i]);
            }
        }

        public void SetTargets(Panel targetsPanel, IPTarget?[] targets)
        {
            TargetView?[] temp = new TargetView[this.targets.Length];
            for (int i = 0; i < this.targets.Length; i++)
            {
                temp[i] = this.targets[i];
            }
            this.targets = new TargetView[targets.Length];
            for (int i = 0; i < targets.Length; i++)
            {
                this.targets[i] = i >= temp.Length ? new TargetView(i, targetsPanel, targets[i]) : temp[i];
            }
            for (int i = targets.Length; i < temp.Length; i++)
            {
                temp[i]?.Remove(targetsPanel);
                temp[i] = null;
            }
        }
    }
}
