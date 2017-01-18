// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: DailyQuestSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Settings.Master.Quest {

  /// <summary>Holder for reflection information generated from DailyQuestSettings.proto</summary>
  public static partial class DailyQuestSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for DailyQuestSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DailyQuestSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhEYWlseVF1ZXN0U2V0dGluZ3MucHJvdG8SIFBPR09Qcm90b3MuU2V0dGlu",
            "Z3MuTWFzdGVyLlF1ZXN0In8KEkRhaWx5UXVlc3RTZXR0aW5ncxIXCg9idWNr",
            "ZXRzX3Blcl9kYXkYASABKAUSFQoNc3RyZWFrX2xlbmd0aBgCIAEoBRIYChBi",
            "b251c19tdWx0aXBsaWVyGAMgASgCEh8KF3N0cmVha19ib251c19tdWx0aXBs",
            "aWVyGAQgASgCYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Settings.Master.Quest.DailyQuestSettings), global::POGOProtos.Settings.Master.Quest.DailyQuestSettings.Parser, new[]{ "BucketsPerDay", "StreakLength", "BonusMultiplier", "StreakBonusMultiplier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class DailyQuestSettings : pb::IMessage<DailyQuestSettings> {
    private static readonly pb::MessageParser<DailyQuestSettings> _parser = new pb::MessageParser<DailyQuestSettings>(() => new DailyQuestSettings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DailyQuestSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Settings.Master.Quest.DailyQuestSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DailyQuestSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DailyQuestSettings(DailyQuestSettings other) : this() {
      bucketsPerDay_ = other.bucketsPerDay_;
      streakLength_ = other.streakLength_;
      bonusMultiplier_ = other.bonusMultiplier_;
      streakBonusMultiplier_ = other.streakBonusMultiplier_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DailyQuestSettings Clone() {
      return new DailyQuestSettings(this);
    }

    /// <summary>Field number for the "buckets_per_day" field.</summary>
    public const int BucketsPerDayFieldNumber = 1;
    private int bucketsPerDay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int BucketsPerDay {
      get { return bucketsPerDay_; }
      set {
        bucketsPerDay_ = value;
      }
    }

    /// <summary>Field number for the "streak_length" field.</summary>
    public const int StreakLengthFieldNumber = 2;
    private int streakLength_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StreakLength {
      get { return streakLength_; }
      set {
        streakLength_ = value;
      }
    }

    /// <summary>Field number for the "bonus_multiplier" field.</summary>
    public const int BonusMultiplierFieldNumber = 3;
    private float bonusMultiplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float BonusMultiplier {
      get { return bonusMultiplier_; }
      set {
        bonusMultiplier_ = value;
      }
    }

    /// <summary>Field number for the "streak_bonus_multiplier" field.</summary>
    public const int StreakBonusMultiplierFieldNumber = 4;
    private float streakBonusMultiplier_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float StreakBonusMultiplier {
      get { return streakBonusMultiplier_; }
      set {
        streakBonusMultiplier_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DailyQuestSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DailyQuestSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BucketsPerDay != other.BucketsPerDay) return false;
      if (StreakLength != other.StreakLength) return false;
      if (BonusMultiplier != other.BonusMultiplier) return false;
      if (StreakBonusMultiplier != other.StreakBonusMultiplier) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (BucketsPerDay != 0) hash ^= BucketsPerDay.GetHashCode();
      if (StreakLength != 0) hash ^= StreakLength.GetHashCode();
      if (BonusMultiplier != 0F) hash ^= BonusMultiplier.GetHashCode();
      if (StreakBonusMultiplier != 0F) hash ^= StreakBonusMultiplier.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (BucketsPerDay != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(BucketsPerDay);
      }
      if (StreakLength != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(StreakLength);
      }
      if (BonusMultiplier != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(BonusMultiplier);
      }
      if (StreakBonusMultiplier != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(StreakBonusMultiplier);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (BucketsPerDay != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(BucketsPerDay);
      }
      if (StreakLength != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StreakLength);
      }
      if (BonusMultiplier != 0F) {
        size += 1 + 4;
      }
      if (StreakBonusMultiplier != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DailyQuestSettings other) {
      if (other == null) {
        return;
      }
      if (other.BucketsPerDay != 0) {
        BucketsPerDay = other.BucketsPerDay;
      }
      if (other.StreakLength != 0) {
        StreakLength = other.StreakLength;
      }
      if (other.BonusMultiplier != 0F) {
        BonusMultiplier = other.BonusMultiplier;
      }
      if (other.StreakBonusMultiplier != 0F) {
        StreakBonusMultiplier = other.StreakBonusMultiplier;
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
            BucketsPerDay = input.ReadInt32();
            break;
          }
          case 16: {
            StreakLength = input.ReadInt32();
            break;
          }
          case 29: {
            BonusMultiplier = input.ReadFloat();
            break;
          }
          case 37: {
            StreakBonusMultiplier = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code