using GalaSoft.MvvmLight;

using CfePocApp.Model;

namespace CfePocApp.ViewModel
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    using GalaSoft.MvvmLight.Command;

    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class TextsViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        public Texts Texts { get; set; }

        /// <summary>
        /// 改变字体
        /// </summary>
        public RelayCommand ChangeFontSizeCommand { get; private set; }

        /// <summary>
        /// 弹出菜单1
        /// </summary>
        public RelayCommand<ContextMenu> PopMenuCommand1 { get; private set; }

        /// <summary>
        /// 复制命令
        /// </summary>
        public RelayCommand CopyCommand { get; private set; }

        /// <summary>
        /// 复制命令
        /// </summary>
        public RelayCommand PasteCommand { get; private set; }

        /// <summary>
        /// 弹出菜单2
        /// </summary>
        public RelayCommand<string> PopMenuCommand2 { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public TextsViewModel(IDataService dataService)
        {
            #region 解析数据

            this._dataService = dataService;
            this._dataService.GetTexts(
                (texts, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }
                    this.Texts = texts;
                });

            #endregion

            #region 命令实现

            ChangeFontSizeCommand = new RelayCommand(
                () => { this.Texts.FontSize = this.Texts.FontSize > 13 ? 12 : 14; },
                () => true);

            PopMenuCommand1 = new RelayCommand<ContextMenu>(menu => { menu.IsOpen = true; }, menu => true);

            CopyCommand = new RelayCommand(() => MessageBox.Show(string.Format("已复制！ | {0}", Texts.TextForMenu)));

            PasteCommand = new RelayCommand(() =>
                    {
                        Texts.TextForMenu = String.Format("CFE NOW! ({0})", DateTime.Now.ToString("yyyyMMdd"));
                        MessageBox.Show("已粘贴！ | CFE NOW!");
                    });

            PopMenuCommand2 = new RelayCommand<string>(str => { CreateMenu(str).IsOpen = true; }, str => true);

            #endregion
        }

        private ContextMenu CreateMenu(string str)
        {
            var contextMenu = new ContextMenu();

            contextMenu.Items.Add(new MenuItem { Header = str, HeaderStringFormat = "Hello,{0}" });
            contextMenu.Items.Add(new MenuItem { Header = "复制", Command = CopyCommand });//InputGestureText = "说明：复制左侧文本"
            contextMenu.Items.Add(new MenuItem { Header = "粘贴", Command = PasteCommand });//InputGestureText = "说明：粘贴回去"
            contextMenu.Items.Add(new MenuItem { Header = "已禁用", IsEnabled = false });
            contextMenu.Items.Add(new MenuItem { Header = "可选择，已选中", IsChecked = true, IsCheckable = true });
            contextMenu.Items.Add(new MenuItem { Header = "已选中，禁用", IsChecked = true, IsEnabled = false });
            contextMenu.Items.Add(new Separator());

            contextMenu.Items.Add(CreateSubMenu("子菜单"));

            var menu = CreateSubMenu("子菜单, 已禁用");
            menu.IsEnabled = false;
            contextMenu.Items.Add(menu);
            return contextMenu;
        }

        private MenuItem CreateSubMenu(string header)
        {
            var item = new MenuItem { Header = header };
            item.Items.Add(new MenuItem { Header = "菜单A" });
            item.Items.Add("菜单B");
            item.Items.Add(new Separator());
            item.Items.Add("菜单C");
            return item;
        }
    }
}