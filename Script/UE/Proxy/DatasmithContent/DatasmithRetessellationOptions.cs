using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithRetessellationOptions")]
	public partial class FDatasmithRetessellationOptions : FDatasmithTessellationOptions, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DatasmithContent.DatasmithRetessellationOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDatasmithRetessellationOptions()
		{
		}

		public static bool operator ==(FDatasmithRetessellationOptions A, FDatasmithRetessellationOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDatasmithRetessellationOptions A, FDatasmithRetessellationOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDatasmithRetessellationOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EDatasmithCADRetessellationRule RetessellationRule
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RetessellationRule, __ReturnBuffer);

					return *(EDatasmithCADRetessellationRule*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RetessellationRule, __InBuffer);
				}
			}
		}

		private static uint __RetessellationRule = 0;

	}
}