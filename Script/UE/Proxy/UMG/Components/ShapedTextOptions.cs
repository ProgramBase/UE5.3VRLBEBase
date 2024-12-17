using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;
using Script.Slate;

namespace Script.UMG
{
	[PathName("/Script/UMG.ShapedTextOptions")]
	public partial class FShapedTextOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UMG.ShapedTextOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FShapedTextOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FShapedTextOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FShapedTextOptions A, FShapedTextOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FShapedTextOptions A, FShapedTextOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FShapedTextOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bOverride_TextShapingMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverride_TextShapingMethod, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverride_TextShapingMethod, __InBuffer);
				}
			}
		}

		public bool bOverride_TextFlowDirection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverride_TextFlowDirection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverride_TextFlowDirection, __InBuffer);
				}
			}
		}

		public ETextShapingMethod TextShapingMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextShapingMethod, __ReturnBuffer);

					return *(ETextShapingMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextShapingMethod, __InBuffer);
				}
			}
		}

		public ETextFlowDirection TextFlowDirection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TextFlowDirection, __ReturnBuffer);

					return *(ETextFlowDirection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TextFlowDirection, __InBuffer);
				}
			}
		}

		private static uint __bOverride_TextShapingMethod = 0;

		private static uint __bOverride_TextFlowDirection = 0;

		private static uint __TextShapingMethod = 0;

		private static uint __TextFlowDirection = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}