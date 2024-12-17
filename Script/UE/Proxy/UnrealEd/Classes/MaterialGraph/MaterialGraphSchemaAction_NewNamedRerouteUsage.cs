using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialGraphSchemaAction_NewNamedRerouteUsage")]
	public partial class FMaterialGraphSchemaAction_NewNamedRerouteUsage : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.MaterialGraphSchemaAction_NewNamedRerouteUsage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialGraphSchemaAction_NewNamedRerouteUsage()
		{
		}

		public static bool operator ==(FMaterialGraphSchemaAction_NewNamedRerouteUsage A, FMaterialGraphSchemaAction_NewNamedRerouteUsage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialGraphSchemaAction_NewNamedRerouteUsage A, FMaterialGraphSchemaAction_NewNamedRerouteUsage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialGraphSchemaAction_NewNamedRerouteUsage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMaterialExpressionNamedRerouteDeclaration Declaration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Declaration, __ReturnBuffer);

					return *(UMaterialExpressionNamedRerouteDeclaration*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Declaration, __InBuffer);
				}
			}
		}

		private static uint __Declaration = 0;

	}
}