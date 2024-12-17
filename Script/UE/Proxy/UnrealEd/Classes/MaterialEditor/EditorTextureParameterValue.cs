using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorTextureParameterValue")]
	public partial class FEditorTextureParameterValue : FEditorParameterValue, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.EditorTextureParameterValue");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEditorTextureParameterValue()
		{
		}

		public static bool operator ==(FEditorTextureParameterValue A, FEditorTextureParameterValue B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEditorTextureParameterValue A, FEditorTextureParameterValue B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEditorTextureParameterValue;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UTexture ParameterValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __ReturnBuffer);

					return *(UTexture*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParameterValue, __InBuffer);
				}
			}
		}

		private static uint __ParameterValue = 0;

	}
}