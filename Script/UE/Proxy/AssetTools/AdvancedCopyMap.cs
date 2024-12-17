using Script.CoreUObject;
using Script.Library;

namespace Script.AssetTools
{
	[PathName("/Script/AssetTools.AdvancedCopyMap")]
	public partial class FAdvancedCopyMap : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AssetTools.AdvancedCopyMap");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAdvancedCopyMap() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAdvancedCopyMap() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAdvancedCopyMap A, FAdvancedCopyMap B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAdvancedCopyMap A, FAdvancedCopyMap B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAdvancedCopyMap;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSoftClassPath ClassToCopy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ClassToCopy, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ClassToCopy, __InBuffer);
				}
			}
		}

		public FSoftClassPath AdvancedCopyCustomization
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AdvancedCopyCustomization, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AdvancedCopyCustomization, __InBuffer);
				}
			}
		}

		private static uint __ClassToCopy = 0;

		private static uint __AdvancedCopyCustomization = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}