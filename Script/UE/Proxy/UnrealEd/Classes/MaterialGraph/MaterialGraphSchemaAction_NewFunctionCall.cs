using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialGraphSchemaAction_NewFunctionCall")]
	public partial class FMaterialGraphSchemaAction_NewFunctionCall : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.MaterialGraphSchemaAction_NewFunctionCall");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialGraphSchemaAction_NewFunctionCall()
		{
		}

		public static bool operator ==(FMaterialGraphSchemaAction_NewFunctionCall A, FMaterialGraphSchemaAction_NewFunctionCall B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialGraphSchemaAction_NewFunctionCall A, FMaterialGraphSchemaAction_NewFunctionCall B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialGraphSchemaAction_NewFunctionCall;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString FunctionPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FunctionPath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FunctionPath, __InBuffer);
				}
			}
		}

		private static uint __FunctionPath = 0;

	}
}