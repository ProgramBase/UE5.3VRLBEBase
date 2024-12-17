using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BoneNode")]
	public partial class FBoneNode : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.BoneNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBoneNode() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBoneNode() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBoneNode A, FBoneNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBoneNode A, FBoneNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBoneNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EBoneTranslationRetargetingMode TranslationRetargetingMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TranslationRetargetingMode, __ReturnBuffer);

					return *(EBoneTranslationRetargetingMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TranslationRetargetingMode, __InBuffer);
				}
			}
		}

		private static uint __TranslationRetargetingMode = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}