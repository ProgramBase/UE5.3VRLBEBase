using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DeviceTriggerBaseData")]
	public partial class FDeviceTriggerBaseData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DeviceTriggerBaseData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDeviceTriggerBaseData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDeviceTriggerBaseData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDeviceTriggerBaseData A, FDeviceTriggerBaseData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDeviceTriggerBaseData A, FDeviceTriggerBaseData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDeviceTriggerBaseData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EInputDeviceTriggerMask AffectedTriggers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AffectedTriggers, __ReturnBuffer);

					return *(EInputDeviceTriggerMask*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AffectedTriggers, __InBuffer);
				}
			}
		}

		public bool bResetUponCompletion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bResetUponCompletion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bResetUponCompletion, __InBuffer);
				}
			}
		}

		private static uint __AffectedTriggers = 0;

		private static uint __bResetUponCompletion = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}