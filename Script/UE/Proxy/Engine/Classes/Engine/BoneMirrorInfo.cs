using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BoneMirrorInfo")]
	public partial class FBoneMirrorInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BoneMirrorInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBoneMirrorInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBoneMirrorInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBoneMirrorInfo A, FBoneMirrorInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBoneMirrorInfo A, FBoneMirrorInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBoneMirrorInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int SourceIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceIndex, __InBuffer);
				}
			}
		}

		public EAxis BoneFlipAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneFlipAxis, __ReturnBuffer);

					return *(EAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneFlipAxis, __InBuffer);
				}
			}
		}

		private static uint __SourceIndex = 0;

		private static uint __BoneFlipAxis = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}