using Script.CoreUObject;
using Script.Library;

namespace Script.ClothPainter
{
	[PathName("/Script/ClothPainter.CopyVertexColorToClothParams")]
	public partial class FCopyVertexColorToClothParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ClothPainter.CopyVertexColorToClothParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCopyVertexColorToClothParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCopyVertexColorToClothParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCopyVertexColorToClothParams A, FCopyVertexColorToClothParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCopyVertexColorToClothParams A, FCopyVertexColorToClothParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCopyVertexColorToClothParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ESourceColorChannel ColorChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ColorChannel, __ReturnBuffer);

					return *(ESourceColorChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ColorChannel, __InBuffer);
				}
			}
		}

		public float ScalingFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScalingFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScalingFactor, __InBuffer);
				}
			}
		}

		private static uint __ColorChannel = 0;

		private static uint __ScalingFactor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}