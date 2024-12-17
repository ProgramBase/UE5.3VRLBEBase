using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithStaticMaterialTemplate")]
	public partial class FDatasmithStaticMaterialTemplate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DatasmithContent.DatasmithStaticMaterialTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDatasmithStaticMaterialTemplate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDatasmithStaticMaterialTemplate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDatasmithStaticMaterialTemplate A, FDatasmithStaticMaterialTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDatasmithStaticMaterialTemplate A, FDatasmithStaticMaterialTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDatasmithStaticMaterialTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName MaterialSlotName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaterialSlotName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaterialSlotName, __InBuffer);
				}
			}
		}

		public UMaterialInterface MaterialInterface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaterialInterface, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaterialInterface, __InBuffer);
				}
			}
		}

		private static uint __MaterialSlotName = 0;

		private static uint __MaterialInterface = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}