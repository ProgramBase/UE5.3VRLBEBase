using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PerBoneBlendWeight")]
	public partial class FPerBoneBlendWeight : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PerBoneBlendWeight");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPerBoneBlendWeight() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPerBoneBlendWeight() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPerBoneBlendWeight A, FPerBoneBlendWeight B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPerBoneBlendWeight A, FPerBoneBlendWeight B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPerBoneBlendWeight;

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

		public float BlendWeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlendWeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlendWeight, __InBuffer);
				}
			}
		}

		private static uint __SourceIndex = 0;

		private static uint __BlendWeight = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}