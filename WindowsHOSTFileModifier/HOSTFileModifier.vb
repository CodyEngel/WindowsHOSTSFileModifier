Imports System
Imports System.IO
Imports System.Text
Imports System.Collections.Generic

Public Class MainForm
    ' Set the path of hosts
    Dim hostsPath As String = System.Environment.GetFolderPath(Environment.SpecialFolder.System) & "\Drivers\etc\"
    Dim desktop As String = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim hostsBackupFile = "temphosts"
    Dim hostsFile = "hosts"
    Dim hostsUserBackupFile = "WHFMhosts"

    '################################################################################
    '#          Backup Button
    '#          Creates a backup of the users hosts file.
    '#
    '#          hosts -> WHFMhosts
    '################################################################################
    Private Sub bBackup_Click(sender As Object, e As EventArgs) Handles bBackup.Click
        copyFile(hostsFile, hostsUserBackupFile)
    End Sub

    Private Sub bRestore_Click(sender As Object, e As EventArgs) Handles bRestore.Click
        copyFile(hostsUserBackupFile, "hosts")
    End Sub

    '################################################################################
    '#          Malware Button
    '#          Appends the hosts file to block websites known to be infected with
    '#          malware.
    '################################################################################
    Private Sub bMalware_Click(sender As Object, e As EventArgs) Handles bMalware.Click
        appendHostFile("http://www.malwaredomainlist.com/hostslist/hosts.txt", "MALWARE")
    End Sub

    '################################################################################
    '#          ZeuS Button
    '#          Appends the hosts file to block websites known to be infected with
    '#          ZeuS.
    '################################################################################
    Private Sub bZeuS_Click(sender As Object, e As EventArgs) Handles bZeuS.Click
        appendHostFile("https://zeustracker.abuse.ch/blocklist.php?download=hostfile", "ZeuS")
    End Sub

    '################################################################################
    '#          Copy Hosts File
    '#          Creates a copy of the hosts file.
    '################################################################################
    Private Sub copyFile(source, destination)
        Dim sourceFileName As String = hostsPath & source
        Dim destinationFileName As String = hostsPath & destination
        Dim overwrite As Boolean = True

        ' Try to copy the hosts file to WHFMHosts
        Try
            FileSystem.FileCopy(sourceFileName, destinationFileName)
        Catch
            ' If the program wasn't run as an administrator it will not work
            MsgBox("This program must be run as an administrator.", , "Error 37!")
            Return
        End Try
    End Sub

    '################################################################################
    '#          Append Host File
    '#          Appends the host file with a list of blocked webistes.
    '################################################################################
    Private Sub appendHostFile(downloadFile, infectionName)
        My.Computer.Network.DownloadFile(downloadFile, desktop & "\blocked-sites.txt", "", "", True, 1000, True)
        If System.IO.File.Exists(hostsPath & hostsBackupFile) = False Then
            copyFile(hostsFile, hostsBackupFile)
        End If

        Dim sb As New StringBuilder()
        Using sr As New StreamReader(hostsPath & "\hosts")
            sb.Append(sr.ReadToEnd())
        End Using
        Using sr As New StreamReader(desktop & "\blocked-sites.txt")
            sb.AppendLine("# START OF KNOWN " & infectionName & " INFECTED WEBSITES")
            sb.Append(sr.ReadToEnd())
            sb.AppendLine("# END OF KNOWN " & infectionName & " INFECTED WEBSITES")
        End Using

        Using outfile As New StreamWriter(hostsPath & "hosts")
            outfile.Write(sb.ToString())
        End Using

        My.Computer.FileSystem.DeleteFile(desktop & "\blocked-sites.txt")
    End Sub
End Class
