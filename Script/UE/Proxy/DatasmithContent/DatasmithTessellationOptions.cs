using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithTessellationOptions")]
	public partial class FDatasmithTessellationOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DatasmithContent.DatasmithTessellationOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDatasmithTessellationOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDatasmithTessellationOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDatasmithTessellationOptions A, FDatasmithTessellationOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDatasmithTessellationOptions A, FDatasmithTessellationOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDatasmithTessellationOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float ChordTolerance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChordTolerance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChordTolerance, __InBuffer);
				}
			}
		}

		public float MaxEdgeLength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxEdgeLength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxEdgeLength, __InBuffer);
				}
			}
		}

		public float NormalTolerance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NormalTolerance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NormalTolerance, __InBuffer);
				}
			}
		}

		public EDatasmithCADStitchingTechnique StitchingTechnique
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StitchingTechnique, __ReturnBuffer);

					return *(EDatasmithCADStitchingTechnique*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StitchingTechnique, __InBuffer);
				}
			}
		}

		private static uint __ChordTolerance = 0;

		private static uint __MaxEdgeLength = 0;

		private static uint __NormalTolerance = 0;

		private static uint __StitchingTechnique = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}