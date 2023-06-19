namespace RPG_BATTLE
{
    partial class Battle
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
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.lblEnemy = new System.Windows.Forms.Label();
            this.txtPlayerHealth = new System.Windows.Forms.TextBox();
            this.txtEnemyHealth = new System.Windows.Forms.TextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnDefend = new System.Windows.Forms.Button();
            this.btnHeal = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Location = new System.Drawing.Point(69, 84);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(38, 13);
            this.lblPlayerHealth.TabIndex = 0;
            this.lblPlayerHealth.Text = "Health";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(110, 65);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(36, 13);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "Player";
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.AutoSize = true;
            this.lblEnemyHealth.Location = new System.Drawing.Point(280, 84);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(38, 13);
            this.lblEnemyHealth.TabIndex = 2;
            this.lblEnemyHealth.Text = "Health";
            // 
            // lblEnemy
            // 
            this.lblEnemy.AutoSize = true;
            this.lblEnemy.Location = new System.Drawing.Point(321, 65);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(39, 13);
            this.lblEnemy.TabIndex = 3;
            this.lblEnemy.Text = "Enemy";
            // 
            // txtPlayerHealth
            // 
            this.txtPlayerHealth.Location = new System.Drawing.Point(113, 81);
            this.txtPlayerHealth.Name = "txtPlayerHealth";
            this.txtPlayerHealth.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerHealth.TabIndex = 4;
            // 
            // txtEnemyHealth
            // 
            this.txtEnemyHealth.Location = new System.Drawing.Point(324, 81);
            this.txtEnemyHealth.Name = "txtEnemyHealth";
            this.txtEnemyHealth.Size = new System.Drawing.Size(100, 20);
            this.txtEnemyHealth.TabIndex = 5;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(72, 146);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(177, 23);
            this.btnAttack.TabIndex = 0;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnDefend
            // 
            this.btnDefend.Location = new System.Drawing.Point(255, 146);
            this.btnDefend.Name = "btnDefend";
            this.btnDefend.Size = new System.Drawing.Size(177, 23);
            this.btnDefend.TabIndex = 7;
            this.btnDefend.Text = "Defend";
            this.btnDefend.UseVisualStyleBackColor = true;
            this.btnDefend.Click += new System.EventHandler(this.btnDefend_Click);
            // 
            // btnHeal
            // 
            this.btnHeal.Location = new System.Drawing.Point(72, 175);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(177, 23);
            this.btnHeal.TabIndex = 8;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            this.btnHeal.Click += new System.EventHandler(this.btnHeal_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(72, 119);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(360, 24);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "lable1";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInfo.Visible = false;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(174, 146);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 52);
            this.btnContinue.TabIndex = 10;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Visible = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(255, 146);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 52);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Battle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 259);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnHeal);
            this.Controls.Add(this.btnDefend);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.txtEnemyHealth);
            this.Controls.Add(this.txtPlayerHealth);
            this.Controls.Add(this.lblEnemy);
            this.Controls.Add(this.lblEnemyHealth);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblPlayerHealth);
            this.Name = "Battle";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblEnemyHealth;
        private System.Windows.Forms.Label lblEnemy;
        private System.Windows.Forms.TextBox txtPlayerHealth;
        private System.Windows.Forms.TextBox txtEnemyHealth;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnDefend;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnExit;
    }
}