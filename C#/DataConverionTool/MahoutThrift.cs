/**
 * Autogenerated by Thrift Compiler (0.9.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

public partial class MahoutThrift {
  public interface Iface {
    string ImportDataInMahout(string hiveTableName, string mahoutTable);
    #if SILVERLIGHT
    IAsyncResult Begin_ImportDataInMahout(AsyncCallback callback, object state, string hiveTableName, string mahoutTable);
    string End_ImportDataInMahout(IAsyncResult asyncResult);
    #endif
    string ExportDataOutMahout(string hiveTableName, string mahoutTable);
    #if SILVERLIGHT
    IAsyncResult Begin_ExportDataOutMahout(AsyncCallback callback, object state, string hiveTableName, string mahoutTable);
    string End_ExportDataOutMahout(IAsyncResult asyncResult);
    #endif
  }

  public class Client : Iface {
    public Client(TProtocol prot) : this(prot, prot)
    {
    }

    public Client(TProtocol iprot, TProtocol oprot)
    {
      iprot_ = iprot;
      oprot_ = oprot;
    }

    protected TProtocol iprot_;
    protected TProtocol oprot_;
    protected int seqid_;

    public TProtocol InputProtocol
    {
      get { return iprot_; }
    }
    public TProtocol OutputProtocol
    {
      get { return oprot_; }
    }


    
    #if SILVERLIGHT
    public IAsyncResult Begin_ImportDataInMahout(AsyncCallback callback, object state, string hiveTableName, string mahoutTable)
    {
      return send_ImportDataInMahout(callback, state, hiveTableName, mahoutTable);
    }

    public string End_ImportDataInMahout(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      return recv_ImportDataInMahout();
    }

    #endif

    public string ImportDataInMahout(string hiveTableName, string mahoutTable)
    {
      #if !SILVERLIGHT
      send_ImportDataInMahout(hiveTableName, mahoutTable);
      return recv_ImportDataInMahout();

      #else
      var asyncResult = Begin_ImportDataInMahout(null, null, hiveTableName, mahoutTable);
      return End_ImportDataInMahout(asyncResult);

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_ImportDataInMahout(AsyncCallback callback, object state, string hiveTableName, string mahoutTable)
    #else
    public void send_ImportDataInMahout(string hiveTableName, string mahoutTable)
    #endif
    {
      oprot_.WriteMessageBegin(new TMessage("ImportDataInMahout", TMessageType.Call, seqid_));
      ImportDataInMahout_args args = new ImportDataInMahout_args();
      args.HiveTableName = hiveTableName;
      args.MahoutTable = mahoutTable;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      #if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
      #else
      oprot_.Transport.Flush();
      #endif
    }

    public string recv_ImportDataInMahout()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      ImportDataInMahout_result result = new ImportDataInMahout_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.success) {
        return result.Success;
      }
      throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "ImportDataInMahout failed: unknown result");
    }

    
    #if SILVERLIGHT
    public IAsyncResult Begin_ExportDataOutMahout(AsyncCallback callback, object state, string hiveTableName, string mahoutTable)
    {
      return send_ExportDataOutMahout(callback, state, hiveTableName, mahoutTable);
    }

    public string End_ExportDataOutMahout(IAsyncResult asyncResult)
    {
      oprot_.Transport.EndFlush(asyncResult);
      return recv_ExportDataOutMahout();
    }

    #endif

    public string ExportDataOutMahout(string hiveTableName, string mahoutTable)
    {
      #if !SILVERLIGHT
      send_ExportDataOutMahout(hiveTableName, mahoutTable);
      return recv_ExportDataOutMahout();

      #else
      var asyncResult = Begin_ExportDataOutMahout(null, null, hiveTableName, mahoutTable);
      return End_ExportDataOutMahout(asyncResult);

      #endif
    }
    #if SILVERLIGHT
    public IAsyncResult send_ExportDataOutMahout(AsyncCallback callback, object state, string hiveTableName, string mahoutTable)
    #else
    public void send_ExportDataOutMahout(string hiveTableName, string mahoutTable)
    #endif
    {
      oprot_.WriteMessageBegin(new TMessage("ExportDataOutMahout", TMessageType.Call, seqid_));
      ExportDataOutMahout_args args = new ExportDataOutMahout_args();
      args.HiveTableName = hiveTableName;
      args.MahoutTable = mahoutTable;
      args.Write(oprot_);
      oprot_.WriteMessageEnd();
      #if SILVERLIGHT
      return oprot_.Transport.BeginFlush(callback, state);
      #else
      oprot_.Transport.Flush();
      #endif
    }

    public string recv_ExportDataOutMahout()
    {
      TMessage msg = iprot_.ReadMessageBegin();
      if (msg.Type == TMessageType.Exception) {
        TApplicationException x = TApplicationException.Read(iprot_);
        iprot_.ReadMessageEnd();
        throw x;
      }
      ExportDataOutMahout_result result = new ExportDataOutMahout_result();
      result.Read(iprot_);
      iprot_.ReadMessageEnd();
      if (result.__isset.success) {
        return result.Success;
      }
      throw new TApplicationException(TApplicationException.ExceptionType.MissingResult, "ExportDataOutMahout failed: unknown result");
    }

  }
  public class Processor : TProcessor {
    public Processor(Iface iface)
    {
      iface_ = iface;
      processMap_["ImportDataInMahout"] = ImportDataInMahout_Process;
      processMap_["ExportDataOutMahout"] = ExportDataOutMahout_Process;
    }

    protected delegate void ProcessFunction(int seqid, TProtocol iprot, TProtocol oprot);
    private Iface iface_;
    protected Dictionary<string, ProcessFunction> processMap_ = new Dictionary<string, ProcessFunction>();

    public bool Process(TProtocol iprot, TProtocol oprot)
    {
      try
      {
        TMessage msg = iprot.ReadMessageBegin();
        ProcessFunction fn;
        processMap_.TryGetValue(msg.Name, out fn);
        if (fn == null) {
          TProtocolUtil.Skip(iprot, TType.Struct);
          iprot.ReadMessageEnd();
          TApplicationException x = new TApplicationException (TApplicationException.ExceptionType.UnknownMethod, "Invalid method name: '" + msg.Name + "'");
          oprot.WriteMessageBegin(new TMessage(msg.Name, TMessageType.Exception, msg.SeqID));
          x.Write(oprot);
          oprot.WriteMessageEnd();
          oprot.Transport.Flush();
          return true;
        }
        fn(msg.SeqID, iprot, oprot);
      }
      catch (IOException)
      {
        return false;
      }
      return true;
    }

    public void ImportDataInMahout_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      ImportDataInMahout_args args = new ImportDataInMahout_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      ImportDataInMahout_result result = new ImportDataInMahout_result();
      result.Success = iface_.ImportDataInMahout(args.HiveTableName, args.MahoutTable);
      oprot.WriteMessageBegin(new TMessage("ImportDataInMahout", TMessageType.Reply, seqid)); 
      result.Write(oprot);
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

    public void ExportDataOutMahout_Process(int seqid, TProtocol iprot, TProtocol oprot)
    {
      ExportDataOutMahout_args args = new ExportDataOutMahout_args();
      args.Read(iprot);
      iprot.ReadMessageEnd();
      ExportDataOutMahout_result result = new ExportDataOutMahout_result();
      result.Success = iface_.ExportDataOutMahout(args.HiveTableName, args.MahoutTable);
      oprot.WriteMessageBegin(new TMessage("ExportDataOutMahout", TMessageType.Reply, seqid)); 
      result.Write(oprot);
      oprot.WriteMessageEnd();
      oprot.Transport.Flush();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ImportDataInMahout_args : TBase
  {
    private string _hiveTableName;
    private string _mahoutTable;

    public string HiveTableName
    {
      get
      {
        return _hiveTableName;
      }
      set
      {
        __isset.hiveTableName = true;
        this._hiveTableName = value;
      }
    }

    public string MahoutTable
    {
      get
      {
        return _mahoutTable;
      }
      set
      {
        __isset.mahoutTable = true;
        this._mahoutTable = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool hiveTableName;
      public bool mahoutTable;
    }

    public ImportDataInMahout_args() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              HiveTableName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              MahoutTable = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ImportDataInMahout_args");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (HiveTableName != null && __isset.hiveTableName) {
        field.Name = "hiveTableName";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(HiveTableName);
        oprot.WriteFieldEnd();
      }
      if (MahoutTable != null && __isset.mahoutTable) {
        field.Name = "mahoutTable";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(MahoutTable);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ImportDataInMahout_args(");
      sb.Append("HiveTableName: ");
      sb.Append(HiveTableName);
      sb.Append(",MahoutTable: ");
      sb.Append(MahoutTable);
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ImportDataInMahout_result : TBase
  {
    private string _success;

    public string Success
    {
      get
      {
        return _success;
      }
      set
      {
        __isset.success = true;
        this._success = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool success;
    }

    public ImportDataInMahout_result() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 0:
            if (field.Type == TType.String) {
              Success = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ImportDataInMahout_result");
      oprot.WriteStructBegin(struc);
      TField field = new TField();

      if (this.__isset.success) {
        if (Success != null) {
          field.Name = "Success";
          field.Type = TType.String;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Success);
          oprot.WriteFieldEnd();
        }
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ImportDataInMahout_result(");
      sb.Append("Success: ");
      sb.Append(Success);
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ExportDataOutMahout_args : TBase
  {
    private string _hiveTableName;
    private string _mahoutTable;

    public string HiveTableName
    {
      get
      {
        return _hiveTableName;
      }
      set
      {
        __isset.hiveTableName = true;
        this._hiveTableName = value;
      }
    }

    public string MahoutTable
    {
      get
      {
        return _mahoutTable;
      }
      set
      {
        __isset.mahoutTable = true;
        this._mahoutTable = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool hiveTableName;
      public bool mahoutTable;
    }

    public ExportDataOutMahout_args() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              HiveTableName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              MahoutTable = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ExportDataOutMahout_args");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (HiveTableName != null && __isset.hiveTableName) {
        field.Name = "hiveTableName";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(HiveTableName);
        oprot.WriteFieldEnd();
      }
      if (MahoutTable != null && __isset.mahoutTable) {
        field.Name = "mahoutTable";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(MahoutTable);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ExportDataOutMahout_args(");
      sb.Append("HiveTableName: ");
      sb.Append(HiveTableName);
      sb.Append(",MahoutTable: ");
      sb.Append(MahoutTable);
      sb.Append(")");
      return sb.ToString();
    }

  }


  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ExportDataOutMahout_result : TBase
  {
    private string _success;

    public string Success
    {
      get
      {
        return _success;
      }
      set
      {
        __isset.success = true;
        this._success = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool success;
    }

    public ExportDataOutMahout_result() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 0:
            if (field.Type == TType.String) {
              Success = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("ExportDataOutMahout_result");
      oprot.WriteStructBegin(struc);
      TField field = new TField();

      if (this.__isset.success) {
        if (Success != null) {
          field.Name = "Success";
          field.Type = TType.String;
          field.ID = 0;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Success);
          oprot.WriteFieldEnd();
        }
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ExportDataOutMahout_result(");
      sb.Append("Success: ");
      sb.Append(Success);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
