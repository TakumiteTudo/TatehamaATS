using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TatehamaATS
{
    public partial class NewMainWindow : Form
    {
        // 埋込フォントコレクション
        PrivateFontCollection privateFonts = new PrivateFontCollection();
        public NewMainWindow()
        {
            InitializeComponent();
            LoadCustomFont();
        }

        /// <summary>
        /// 埋め込んだフォントを読み込み、フォームに設定する
        /// </summary>
        private void LoadCustomFont()
        {
            // フォントファイルのパス（プロジェクトに追加されたフォント）
            string fontPath = "PathToYourFontFile.ttf";

            // フォントのメモリ領域に読み込む
            privateFonts.AddFontFile(fontPath);

            // ラベルなどにフォントを適用
            Font customFont = new Font(privateFonts.Families[0], 12);
            this.label1.Font = customFont;
        }


        // リソースを解放するために、Disposeのオーバーライドが必要
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                privateFonts.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
