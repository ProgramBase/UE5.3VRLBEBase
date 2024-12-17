using Script.CoreUObject;
using Script.Library;

namespace Script.SequenceRecorder
{
	[PathName("/Script/SequenceRecorder.TimecodeBoneMethod")]
	public partial class FTimecodeBoneMethod : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SequenceRecorder.TimecodeBoneMethod");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTimecodeBoneMethod() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTimecodeBoneMethod() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTimecodeBoneMethod A, FTimecodeBoneMethod B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTimecodeBoneMethod A, FTimecodeBoneMethod B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTimecodeBoneMethod;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ETimecodeBoneMode BoneMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneMode, __ReturnBuffer);

					return *(ETimecodeBoneMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneMode, __InBuffer);
				}
			}
		}

		public FName BoneName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneName, __InBuffer);
				}
			}
		}

		private static uint __BoneMode = 0;

		private static uint __BoneName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}