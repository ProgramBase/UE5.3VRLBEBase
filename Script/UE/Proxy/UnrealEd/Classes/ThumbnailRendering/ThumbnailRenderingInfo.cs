using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ThumbnailRenderingInfo")]
	public partial class FThumbnailRenderingInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.ThumbnailRenderingInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FThumbnailRenderingInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FThumbnailRenderingInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FThumbnailRenderingInfo A, FThumbnailRenderingInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FThumbnailRenderingInfo A, FThumbnailRenderingInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FThumbnailRenderingInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ClassNeedingThumbnailName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ClassNeedingThumbnailName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ClassNeedingThumbnailName, __InBuffer);
				}
			}
		}

		public TSubclassOf<UObject> ClassNeedingThumbnail
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ClassNeedingThumbnail, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ClassNeedingThumbnail, __InBuffer);
				}
			}
		}

		public FString RendererClassName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RendererClassName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RendererClassName, __InBuffer);
				}
			}
		}

		public UThumbnailRenderer Renderer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Renderer, __ReturnBuffer);

					return *(UThumbnailRenderer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Renderer, __InBuffer);
				}
			}
		}

		private static uint __ClassNeedingThumbnailName = 0;

		private static uint __ClassNeedingThumbnail = 0;

		private static uint __RendererClassName = 0;

		private static uint __Renderer = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}