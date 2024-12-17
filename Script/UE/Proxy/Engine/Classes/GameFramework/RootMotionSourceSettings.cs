using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RootMotionSourceSettings")]
	public partial class FRootMotionSourceSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RootMotionSourceSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRootMotionSourceSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRootMotionSourceSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRootMotionSourceSettings A, FRootMotionSourceSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRootMotionSourceSettings A, FRootMotionSourceSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRootMotionSourceSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public byte Flags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Flags, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Flags, __InBuffer);
				}
			}
		}

		private static uint __Flags = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}