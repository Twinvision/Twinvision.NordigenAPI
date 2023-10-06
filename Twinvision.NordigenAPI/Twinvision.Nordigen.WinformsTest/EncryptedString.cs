using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

public class EncryptedString
{

    private string CEncryptedValue = "";

    private string CValue;
    private string EncryptString(string value)
    {
        Twinvision.RijndaelEncryption.EncryptedString es = new Twinvision.RijndaelEncryption.EncryptedString();
        if (value == null)
        {
            value = string.Empty;
        }
        es.Value = value;
        return es.EncryptedValue;
    }

    private string DecryptString(string value)
    {
        Twinvision.RijndaelEncryption.EncryptedString es = new Twinvision.RijndaelEncryption.EncryptedString();
        if (value != null)
        {
            es.EncryptedValue = value;
            return es.Value;
        }
        else
        {
            return string.Empty;
        }
    }

    public string Value
    {
        get { return CValue; }
        set
        {
            CEncryptedValue = EncryptString(value);
            CValue = value;
        }
    }

    public string EncryptedValue
    {
        get { return CEncryptedValue; }
        set
        {
            CValue = DecryptString(value);
            CEncryptedValue = value;
        }
    }

}