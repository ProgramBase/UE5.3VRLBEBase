using Script.CoreUObject;
using Script.Library;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.LandscapeFileResolution")]
	public partial class FLandscapeFileResolution : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LandscapeEditor.LandscapeFileResolution");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLandscapeFileResolution() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLandscapeFileResolution() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLandscapeFileResolution A, FLandscapeFileResolution B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLandscapeFileResolution A, FLandscapeFileResolution B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLandscapeFileResolution;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint Width
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Width, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Width, __InBuffer);
				}
			}
		}

		public uint Height
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Height, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Height, __InBuffer);
				}
			}
		}

		private static uint __Width = 0;

		private static uint __Height = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}