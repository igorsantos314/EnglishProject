namespace Logicando
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_about = new System.Windows.Forms.Button();
            this.bt_right = new System.Windows.Forms.Button();
            this.bt_left = new System.Windows.Forms.Button();
            this.bt_proceed = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_while = new System.Windows.Forms.Button();
            this.bt_condition = new System.Windows.Forms.Button();
            this.bt_park = new System.Windows.Forms.Button();
            this.lbl_lista = new System.Windows.Forms.Label();
            this.lbl_actions = new System.Windows.Forms.Label();
            this.lb_actions = new System.Windows.Forms.ListBox();
            this.gb_Condition = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.gb_Condition.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_start
            // 
            this.bt_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start.Image = ((System.Drawing.Image)(resources.GetObject("bt_start.Image")));
            this.bt_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_start.Location = new System.Drawing.Point(336, 55);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(239, 70);
            this.bt_start.TabIndex = 0;
            this.bt_start.Text = "START";
            this.bt_start.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_about
            // 
            this.bt_about.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_about.Image = ((System.Drawing.Image)(resources.GetObject("bt_about.Image")));
            this.bt_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_about.Location = new System.Drawing.Point(336, 155);
            this.bt_about.Name = "bt_about";
            this.bt_about.Size = new System.Drawing.Size(239, 70);
            this.bt_about.TabIndex = 1;
            this.bt_about.Text = "ABOUT";
            this.bt_about.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_about.UseVisualStyleBackColor = true;
            // 
            // bt_right
            // 
            this.bt_right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_right.BackgroundImage")));
            this.bt_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_right.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_right.Location = new System.Drawing.Point(23, 318);
            this.bt_right.Name = "bt_right";
            this.bt_right.Size = new System.Drawing.Size(120, 103);
            this.bt_right.TabIndex = 2;
            this.bt_right.Text = "RIGHT";
            this.bt_right.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_right.UseVisualStyleBackColor = true;
            this.bt_right.Visible = false;
            this.bt_right.Click += new System.EventHandler(this.bt_right_Click);
            // 
            // bt_left
            // 
            this.bt_left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_left.BackgroundImage")));
            this.bt_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_left.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_left.Location = new System.Drawing.Point(149, 318);
            this.bt_left.Name = "bt_left";
            this.bt_left.Size = new System.Drawing.Size(120, 103);
            this.bt_left.TabIndex = 2;
            this.bt_left.Text = "LEFT";
            this.bt_left.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_left.UseVisualStyleBackColor = true;
            this.bt_left.Visible = false;
            this.bt_left.Click += new System.EventHandler(this.bt_left_Click);
            // 
            // bt_proceed
            // 
            this.bt_proceed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_proceed.BackgroundImage")));
            this.bt_proceed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_proceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_proceed.Location = new System.Drawing.Point(275, 318);
            this.bt_proceed.Name = "bt_proceed";
            this.bt_proceed.Size = new System.Drawing.Size(120, 103);
            this.bt_proceed.TabIndex = 2;
            this.bt_proceed.Text = "PROCEED";
            this.bt_proceed.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_proceed.UseVisualStyleBackColor = true;
            this.bt_proceed.Visible = false;
            this.bt_proceed.Click += new System.EventHandler(this.bt_proceed_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_stop.BackgroundImage")));
            this.bt_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_stop.Location = new System.Drawing.Point(401, 318);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(120, 103);
            this.bt_stop.TabIndex = 2;
            this.bt_stop.Text = "STOP";
            this.bt_stop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Visible = false;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_while
            // 
            this.bt_while.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_while.BackgroundImage")));
            this.bt_while.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_while.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_while.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_while.Location = new System.Drawing.Point(653, 318);
            this.bt_while.Name = "bt_while";
            this.bt_while.Size = new System.Drawing.Size(120, 103);
            this.bt_while.TabIndex = 2;
            this.bt_while.Text = "WHILE";
            this.bt_while.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_while.UseVisualStyleBackColor = true;
            this.bt_while.Visible = false;
            // 
            // bt_condition
            // 
            this.bt_condition.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_condition.BackgroundImage")));
            this.bt_condition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_condition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_condition.Location = new System.Drawing.Point(527, 318);
            this.bt_condition.Name = "bt_condition";
            this.bt_condition.Size = new System.Drawing.Size(120, 103);
            this.bt_condition.TabIndex = 2;
            this.bt_condition.Text = "CONDITION";
            this.bt_condition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_condition.UseVisualStyleBackColor = true;
            this.bt_condition.Visible = false;
            this.bt_condition.Click += new System.EventHandler(this.bt_condition_Click);
            // 
            // bt_park
            // 
            this.bt_park.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_park.BackgroundImage")));
            this.bt_park.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_park.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_park.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_park.Location = new System.Drawing.Point(779, 318);
            this.bt_park.Name = "bt_park";
            this.bt_park.Size = new System.Drawing.Size(120, 103);
            this.bt_park.TabIndex = 2;
            this.bt_park.Text = "PARK";
            this.bt_park.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_park.UseVisualStyleBackColor = true;
            this.bt_park.Visible = false;
            this.bt_park.Click += new System.EventHandler(this.bt_park_Click);
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lista.Location = new System.Drawing.Point(23, 281);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(244, 29);
            this.lbl_lista.TabIndex = 3;
            this.lbl_lista.Text = "Lista de Comandos:";
            this.lbl_lista.Visible = false;
            // 
            // lbl_actions
            // 
            this.lbl_actions.AutoSize = true;
            this.lbl_actions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_actions.Location = new System.Drawing.Point(20, 9);
            this.lbl_actions.Name = "lbl_actions";
            this.lbl_actions.Size = new System.Drawing.Size(135, 24);
            this.lbl_actions.TabIndex = 4;
            this.lbl_actions.Text = "Your Actions:";
            this.lbl_actions.Visible = false;
            // 
            // lb_actions
            // 
            this.lb_actions.BackColor = System.Drawing.Color.Black;
            this.lb_actions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_actions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_actions.ForeColor = System.Drawing.Color.White;
            this.lb_actions.FormattingEnabled = true;
            this.lb_actions.ItemHeight = 15;
            this.lb_actions.Location = new System.Drawing.Point(24, 37);
            this.lb_actions.Name = "lb_actions";
            this.lb_actions.Size = new System.Drawing.Size(173, 225);
            this.lb_actions.TabIndex = 5;
            this.lb_actions.Visible = false;
            // 
            // gb_Condition
            // 
            this.gb_Condition.Controls.Add(this.button3);
            this.gb_Condition.Controls.Add(this.button2);
            this.gb_Condition.Controls.Add(this.button1);
            this.gb_Condition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Condition.Location = new System.Drawing.Point(436, 67);
            this.gb_Condition.Name = "gb_Condition";
            this.gb_Condition.Size = new System.Drawing.Size(247, 158);
            this.gb_Condition.TabIndex = 6;
            this.gb_Condition.TabStop = false;
            this.gb_Condition.Text = "Condition";
            this.gb_Condition.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Traffic light";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(43, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Walker";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(43, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Max Speed";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.gb_Condition);
            this.Controls.Add(this.lb_actions);
            this.Controls.Add(this.lbl_actions);
            this.Controls.Add(this.lbl_lista);
            this.Controls.Add(this.bt_park);
            this.Controls.Add(this.bt_condition);
            this.Controls.Add(this.bt_while);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_proceed);
            this.Controls.Add(this.bt_left);
            this.Controls.Add(this.bt_right);
            this.Controls.Add(this.bt_about);
            this.Controls.Add(this.bt_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_Condition.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_about;
        private System.Windows.Forms.Button bt_right;
        private System.Windows.Forms.Button bt_left;
        private System.Windows.Forms.Button bt_proceed;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_while;
        private System.Windows.Forms.Button bt_condition;
        private System.Windows.Forms.Button bt_park;
        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.Label lbl_actions;
        private System.Windows.Forms.ListBox lb_actions;
        private System.Windows.Forms.GroupBox gb_Condition;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

