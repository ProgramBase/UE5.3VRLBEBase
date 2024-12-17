using Script.CoreUObject;
using Script.Library;
using Script.Engine;
using Script.AnimationCore;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.ReferenceBoneFrame")]
	public partial class FReferenceBoneFrame : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.ReferenceBoneFrame");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FReferenceBoneFrame() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FReferenceBoneFrame() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FReferenceBoneFrame A, FReferenceBoneFrame B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FReferenceBoneFrame A, FReferenceBoneFrame B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FReferenceBoneFrame;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FBoneReference Bone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bone, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Bone, __InBuffer);
				}
			}
		}

		public FAxis Axis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Axis, __ReturnBuffer);

					return *(FAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Axis, __InBuffer);
				}
			}
		}

		private static uint __Bone = 0;

		private static uint __Axis = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}