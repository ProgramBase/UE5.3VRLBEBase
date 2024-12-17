using Script.CoreUObject;
using Script.Library;

namespace Script.LandscapeEditor
{
	[PathName("/Script/LandscapeEditor.LandscapeImportFileDescriptor")]
	public partial class FLandscapeImportFileDescriptor : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LandscapeEditor.LandscapeImportFileDescriptor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLandscapeImportFileDescriptor() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLandscapeImportFileDescriptor() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLandscapeImportFileDescriptor A, FLandscapeImportFileDescriptor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLandscapeImportFileDescriptor A, FLandscapeImportFileDescriptor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLandscapeImportFileDescriptor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FIntPoint Coord
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Coord, __ReturnBuffer);

					return *(FIntPoint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Coord, __InBuffer);
				}
			}
		}

		public FString FilePath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilePath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilePath, __InBuffer);
				}
			}
		}

		private static uint __Coord = 0;

		private static uint __FilePath = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}