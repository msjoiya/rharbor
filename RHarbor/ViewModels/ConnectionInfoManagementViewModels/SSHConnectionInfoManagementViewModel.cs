﻿using kenzauros.RHarbor.Models;
using kenzauros.RHarbor.MvvmDialog;
using kenzauros.RHarbor.Properties;
using Microsoft.Win32;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Threading.Tasks;

namespace kenzauros.RHarbor.ViewModels
{
    internal class SSHConnectionInfoManagementViewModel : ConnectionInfoManagementViewModel<SSHConnectionInfo>
    {
        public ReactiveCommand SelectPrivateKeyFileCommand { get; set; }
        public ReactiveCommand AddNewPortForwardingCommand { get; set; }
        public ReactiveCommand<PortForwarding> RemovePortForwardingCommand { get; set; }

        public SSHConnectionInfoManagementViewModel() : base()
        {
            SelectPrivateKeyFileCommand = IsItemEditing.ToReactiveCommand();
            SelectPrivateKeyFileCommand.Subscribe(async () =>
            {
                var openFileDialog = new OpenFileDialog
                {
                    FilterIndex = 1,
                    Filter = "Private Key Files (*.*)|*.*"
                };
                if (openFileDialog.ShowDialog() == true)
                {
                    EditingItem.Value.PrivateKeyFilePath = openFileDialog.FileName;
                }
                else
                {
                    var result = await MainWindow.ShowConfirmationDialog(
                        Resources.SSHConnectionInfo_Dialog_ClearPrivateKeyFilePath_Message,
                        Resources.SSHConnectionInfo_Dialog_ClearPrivateKeyFilePath_Title);
                    if (result) EditingItem.Value.PrivateKeyFilePath = null;
                }
            }).AddTo(Disposable);

            AddNewPortForwardingCommand = IsItemEditing.ToReactiveCommand();
            AddNewPortForwardingCommand.Subscribe(() =>
            {
                EditingItem.Value.PortForwardingCollection.Add(new PortForwarding());
            }).AddTo(Disposable);

            RemovePortForwardingCommand = IsItemEditing.ToReactiveCommand<PortForwarding>();
            RemovePortForwardingCommand.Subscribe(item =>
            {
                EditingItem.Value.PortForwardingCollection.Remove(item);
            }).AddTo(Disposable);
        }

        protected override async Task<(bool result, SSHConnectionInfo record)> Save(SSHConnectionInfo item)
        {
            var result = await base.Save(item);
            await SSHConnectionInfo.RefreshAll(MainWindow.DbContext);
            return result;
        }
    }
}
