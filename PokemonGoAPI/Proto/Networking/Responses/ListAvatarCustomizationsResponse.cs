// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ListAvatarCustomizationsResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from ListAvatarCustomizationsResponse.proto</summary>
  public static partial class ListAvatarCustomizationsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for ListAvatarCustomizationsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ListAvatarCustomizationsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZMaXN0QXZhdGFyQ3VzdG9taXphdGlvbnNSZXNwb25zZS5wcm90bxIfUE9H",
            "T1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcxowUE9HT1Byb3Rvcy9EYXRh",
            "L0F2YXRhci9BdmF0YXJDdXN0b21pemF0aW9uLnByb3RvIvcBCiBMaXN0QXZh",
            "dGFyQ3VzdG9taXphdGlvbnNSZXNwb25zZRJYCgZyZXN1bHQYASABKA4ySC5Q",
            "T0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLkxpc3RBdmF0YXJDdXN0",
            "b21pemF0aW9uc1Jlc3BvbnNlLlJlc3VsdBJKChVhdmF0YXJfY3VzdG9taXph",
            "dGlvbnMYAiABKAsyKy5QT0dPUHJvdG9zLkRhdGEuQXZhdGFyLkF2YXRhckN1",
            "c3RvbWl6YXRpb24iLQoGUmVzdWx0EgkKBVVOU0VUEAASCwoHU1VDQ0VTUxAB",
            "EgsKB0ZBSUxVUkUQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.Avatar.AvatarCustomizationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponse), global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponse.Parser, new[]{ "Result", "AvatarCustomizations" }, null, new[]{ typeof(global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ListAvatarCustomizationsResponse : pb::IMessage<ListAvatarCustomizationsResponse> {
    private static readonly pb::MessageParser<ListAvatarCustomizationsResponse> _parser = new pb::MessageParser<ListAvatarCustomizationsResponse>(() => new ListAvatarCustomizationsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListAvatarCustomizationsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListAvatarCustomizationsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListAvatarCustomizationsResponse(ListAvatarCustomizationsResponse other) : this() {
      result_ = other.result_;
      AvatarCustomizations = other.avatarCustomizations_ != null ? other.AvatarCustomizations.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListAvatarCustomizationsResponse Clone() {
      return new ListAvatarCustomizationsResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponse.Types.Result result_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "avatar_customizations" field.</summary>
    public const int AvatarCustomizationsFieldNumber = 2;
    private global::POGOProtos.Data.Avatar.AvatarCustomization avatarCustomizations_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.Avatar.AvatarCustomization AvatarCustomizations {
      get { return avatarCustomizations_; }
      set {
        avatarCustomizations_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListAvatarCustomizationsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListAvatarCustomizationsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (!object.Equals(AvatarCustomizations, other.AvatarCustomizations)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      if (avatarCustomizations_ != null) hash ^= AvatarCustomizations.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (avatarCustomizations_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(AvatarCustomizations);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (avatarCustomizations_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AvatarCustomizations);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListAvatarCustomizationsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      if (other.avatarCustomizations_ != null) {
        if (avatarCustomizations_ == null) {
          avatarCustomizations_ = new global::POGOProtos.Data.Avatar.AvatarCustomization();
        }
        AvatarCustomizations.MergeFrom(other.AvatarCustomizations);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            result_ = (global::POGOProtos.Networking.Responses.ListAvatarCustomizationsResponse.Types.Result) input.ReadEnum();
            break;
          }
          case 18: {
            if (avatarCustomizations_ == null) {
              avatarCustomizations_ = new global::POGOProtos.Data.Avatar.AvatarCustomization();
            }
            input.ReadMessage(avatarCustomizations_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ListAvatarCustomizationsResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("FAILURE")] Failure = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code