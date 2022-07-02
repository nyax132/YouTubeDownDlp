﻿using Microsoft.WindowsAPICodePack.Dialogs;


namespace YouTubeDownDlp.Components
{
    internal static class FolderBrowserComponents
    {
        public static string FolderSelect()
        {
            // ダイアログのインスタンスを生成
            using var dialog = new CommonOpenFileDialog("フォルダーの選択")
            {
                // 選択形式をフォルダースタイルに
                IsFolderPicker = true,
            };

            // ダイアログを表示
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return dialog.FileName;
            }

            return "none";
        }
    }
}
