namespace Ex3
{ 
    partial class formClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView_cl = new System.Windows.Forms.ListView();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.lb_address = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.lb_port = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_cl
            // 
            this.listView_cl.HideSelection = false;
            this.listView_cl.Location = new System.Drawing.Point(41, 146);
            this.listView_cl.Name = "listView_cl";
            this.listView_cl.Size = new System.Drawing.Size(696, 336);
            this.listView_cl.TabIndex = 0;
            this.listView_cl.UseCompatibleStateImageBehavior = false;
            this.listView_cl.View = System.Windows.Forms.View.List;
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(41, 506);
            this.txt_send.Multiline = true;
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(696, 43);
            this.txt_send.TabIndex = 1;
            this.txt_send.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_send_KeyDown);
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(769, 503);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(104, 46);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Location = new System.Drawing.Point(756, 146);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(117, 48);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_disconnect.Location = new System.Drawing.Point(756, 258);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(117, 48);
            this.btn_disconnect.TabIndex = 4;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(38, 53);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(79, 15);
            this.lb_address.TabIndex = 5;
            this.lb_address.Text = "IP Address:";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(123, 48);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(309, 20);
            this.txt_IP.TabIndex = 6;
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_port.Location = new System.Drawing.Point(38, 102);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(37, 15);
            this.lb_port.TabIndex = 7;
            this.lb_port.Text = "Port:";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(123, 101);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(309, 20);
            this.txt_port.TabIndex = 8;
            this.txt_port.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_port_KeyDown);
            // 
            // formClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(910, 623);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.lb_port);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.listView_cl);
            this.Name = "formClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.fClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_cl;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.TextBox txt_port;
    }
}