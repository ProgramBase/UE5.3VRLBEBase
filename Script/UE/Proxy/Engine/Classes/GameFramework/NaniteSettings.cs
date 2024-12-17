using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NaniteSettings")]
	public partial class FNaniteSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.NaniteSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNaniteSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNaniteSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNaniteSettings A, FNaniteSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNaniteSettings A, FNaniteSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNaniteSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bAllowMaskedMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowMaskedMaterials, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowMaskedMaterials, __InBuffer);
				}
			}
		}

		private static uint __bAllowMaskedMaterials = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}