using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StaticParameterSet")]
	public partial class FStaticParameterSet : FStaticParameterSetRuntimeData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.StaticParameterSet");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FStaticParameterSet()
		{
		}

		public static bool operator ==(FStaticParameterSet A, FStaticParameterSet B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FStaticParameterSet A, FStaticParameterSet B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FStaticParameterSet;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FStaticParameterSetEditorOnlyData EditorOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EditorOnly, __ReturnBuffer);

					return *(FStaticParameterSetEditorOnlyData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EditorOnly, __InBuffer);
				}
			}
		}

		private static uint __EditorOnly = 0;

	}
}