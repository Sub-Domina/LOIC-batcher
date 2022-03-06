namespace LOIC_Batcher
{
    internal class TargetView
    {
        public TextBox ip;
        public TextBox port;
        public TextBox method;

        private IPTarget target;

        public TargetView(int index, Panel targetsPanel, IPTarget? target)
        {
            this.target = target!;

            ip = new TextBox();
            ip.Name = "ip" + index;
            ip.Text = this.target.Ip;
            ip.BackColor = SystemColors.ControlLight;
            ip.ForeColor = SystemColors.Highlight;
            ip.BorderStyle = BorderStyle.FixedSingle;
            ip.Size = new Size(100, 23);
            ip.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            ip.Location = new Point(3, 3 + 29 * index);
            ip.TextChanged += Ip_TextChanged;
            targetsPanel.Controls.Add(ip);

            port = new TextBox();
            port.Name = "port" + index;
            port.Text = this.target.Port;
            port.BackColor = SystemColors.ControlLight;
            port.ForeColor = SystemColors.Highlight;
            port.BorderStyle = BorderStyle.FixedSingle;
            port.Size = new Size(55, 23);
            port.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            port.Location = new Point(109, 3 + 29 * index);
            port.TextChanged += Port_TextChanged;
            targetsPanel.Controls.Add(port);

            method = new TextBox();
            method.Name = "method" + index;
            method.Text = this.target.Method;
            method.BackColor = SystemColors.ControlLight;
            method.ForeColor = SystemColors.Highlight;
            method.BorderStyle = BorderStyle.FixedSingle;
            method.Size = new Size(55, 23);
            method.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            method.Location = new Point(170, 3 + 29 * index);
            method.TextChanged += Method_TextChanged;
            targetsPanel.Controls.Add(method);
        }

        public void SetTarget(IPTarget target)
        {
            this.target = target;

            ip.TextChanged -= Ip_TextChanged;
            ip.Text = target.Ip;
            ip.TextChanged += Ip_TextChanged;

            port.TextChanged -= Port_TextChanged;
            port.Text = target.Port;
            port.TextChanged += Port_TextChanged;

            method.TextChanged -= Method_TextChanged;
            method.Text = target.Method;
            method.TextChanged += Method_TextChanged;
        }

        public void Remove(Panel targetsPanel)
        {
            targetsPanel.Controls.Remove(ip);
            ip.Dispose();

            targetsPanel.Controls.Remove(port);
            port.Dispose();

            targetsPanel.Controls.Remove(method);
            method.Dispose();
        }

        private void Ip_TextChanged(object? sender, EventArgs e)
        {
            target.Ip = ip.Text;
        }

        private void Port_TextChanged(object? sender, EventArgs e)
        {
            target.Port = port.Text;
        }

        private void Method_TextChanged(object? sender, EventArgs e)
        {
            target.Method = method.Text;
        }
    }
}
