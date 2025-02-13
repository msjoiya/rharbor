RHarbor - Remote Desktop Management Tool
=====

RHarbor helps you to manage your Remote Desktop connections.

## Features

- Remote Desktop (RDP) connection information management
    - Configurable properties: Host, Port, User name, Screen size, Full screen setting and Admin mode
    - Prior SSH connection to connect the RDP
    - Grouping
    - Search by the connection name or the host name
    - Replication of an existing information
- SSH connection information management
    - Configurable properties: Host, Port, User name, Password/Pass phrase, Private key for the server, Keep alive
    - Fixed port forwarding
    - Prior SSH connection to connect the SSH
    - Grouping
    - Search by the connection name or the host name
    - Replication of an existing information
- Jump List
    - RDP/SSH connection starting by Jump List in Windows Task Bar

## Description

With RHarbor, you can manage your multiple connection informations for Remote Desktop.

You need not to feel the change of usability since RHarbor uses Windows-standard remote desktop application (`mstsc.exe`).

RHarbor is recommended for the following people.

- You need to connect to many remote servers
- You need to connect to a remote server via SSH servers (so-called "bastion")
- You need to forward a port of a remote server easily

Especially it comes in handy when you have to go through the multiple SSH server to connect the destination Windows machine.

## Environment

- v1 series (.NET Framework based)
    - Windwos 7 SP1+
    - .NET Framework 4.6.1
- v2 series (.NET Core based)
    - Windwos 7 SP1+
    - .NET Core 3.1

Install a suitable of .NET Runtime from the following page.

- [Download .NET (Linux, macOS, and Windows)](https://dotnet.microsoft.com/download)

## Download and Install

Download the zip file (`RHarbor_vN.N.N.zip`) from [Release Page](https://github.com/kenzauros/rharbor/releases).

RHarbor needs no special installation. Please unzip the downloaded file into a suitable folder and just start `RHarbor.exe`.

To uninstall, just delete the folder you installed.

## Update

To apply an updated version, overwrite all of files contained in the zip file.

## How to use

Please see the detail pages.

1. [Remote Desktop with multi-hop SSH](https://kenzauros.github.io/rharbor/rdp-with-multi-hop-ssh.html)
1. [Starting connection from Jump List](https://kenzauros.github.io/rharbor/jump-list.html)

Refer to the No.1 even if you connect to a remote server directly.

## About connection settings

### Where to store

`RHarbor.db` exists in the same folder as `RHarbor.exe`. This file contains RHarbor's settings you were set.

### Clear all settings

To initialize the setting please shutdown RHarbor and then delete `RHarbor.db`. New `RHarbor.db` will be generated when you start RHarbor again.

### Back up

To back up your connection settings, just copy `RHarbor.db` to your backup location.

RHarbor automatically backs it up to your profile folder (typically `C:\Users\<Username>\AppData\Roaming\RHarbor`).

## Notice

### SSH private key file

OpenSSH-format private key files (e.g. generated by `ssh-keygen`) are allowed.

PuTTy format private key files should be converted to OpenSSH format using [puttygen.exe](https://www.chiark.greenend.org.uk/~sgtatham/putty/latest.html).

RHarbor doesn't care the key file extension.

### Password security

The passwords stored in RHarbor are encrypted but still remains some security risks.

Do not install in a shared computer.

Malicious programs or bad people may read passwords in the database file or in memory.

Please make sure that an appropriate antivirus software is installed on your computer and use on your own risk.

## Licence

MIT

## Special Thanks to

- [Extended.Wpf.Toolkit](https://github.com/xceedsoftware/wpftoolkit)
- [Json.NET](https://www.newtonsoft.com/json)
- [NLog](https://nlog-project.org/)
- [ReactiveProperty](https://github.com/runceel/ReactiveProperty)
- [SSH.NET](https://github.com/sshnet/SSH.NET/)
- [System.Data.SQLite](https://system.data.sqlite.org/index.html/doc/trunk/www/index.wiki)
- [System.Data.SQLite.EF6.Migrations](https://github.com/bubibubi/db2ef6migrations)

## Author

- [kenzauros](https://github.com/kenzauros)
