using Script.CoreUObject;
using Script.Library;

namespace Script.SlateCore
{
	[PathName("/Script/SlateCore.StyleColorList")]
	public partial class FStyleColorList : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SlateCore.StyleColorList");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStyleColorList() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FStyleColorList() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FStyleColorList A, FStyleColorList B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStyleColorList A, FStyleColorList B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStyleColorList;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLinearColor StyleColors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StyleColors, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StyleColors, __InBuffer);
				}
			}
		}

		private static uint __StyleColors = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}