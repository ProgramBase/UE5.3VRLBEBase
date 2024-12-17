using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.StreamableRenderAsset")]
	public partial class UStreamableRenderAsset : UObject, IStaticClass
	{
		public double ForceMipLevelsToBeResidentTimestamp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForceMipLevelsToBeResidentTimestamp, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForceMipLevelsToBeResidentTimestamp, __InBuffer);
				}
			}
		}

		public int NumCinematicMipLevels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumCinematicMipLevels, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumCinematicMipLevels, __InBuffer);
				}
			}
		}

		public FPerQualityLevelInt NoRefStreamingLODBias
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NoRefStreamingLODBias, __ReturnBuffer);

					return *(FPerQualityLevelInt*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NoRefStreamingLODBias, __InBuffer);
				}
			}
		}

		public int StreamingIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingIndex, __InBuffer);
				}
			}
		}

		public bool NeverStream
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NeverStream, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NeverStream, __InBuffer);
				}
			}
		}

		public bool bGlobalForceMipLevelsToBeResident
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bGlobalForceMipLevelsToBeResident, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bGlobalForceMipLevelsToBeResident, __InBuffer);
				}
			}
		}

		public bool bHasStreamingUpdatePending
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasStreamingUpdatePending, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasStreamingUpdatePending, __InBuffer);
				}
			}
		}

		public bool bForceMiplevelsToBeResident
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceMiplevelsToBeResident, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceMiplevelsToBeResident, __InBuffer);
				}
			}
		}

		public bool bIgnoreStreamingMipBias
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreStreamingMipBias, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreStreamingMipBias, __InBuffer);
				}
			}
		}

		public bool bUseCinematicMipLevels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseCinematicMipLevels, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseCinematicMipLevels, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.StreamableRenderAsset");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Seconds">
		/// Duration in seconds
		/// </param>
		/// <param name="CinematicTextureGroups">
		/// Bitfield indicating which texture groups that use extra high-resolution mips
		/// </param>
		public virtual void SetForceMipLevelsToBeResident(float Seconds, int CinematicLODGroupMask = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = Seconds;

				*(int*)(__InBuffer + 4) = CinematicLODGroupMask;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetForceMipLevelsToBeResident, __InBuffer);
			}
		}

		private static uint __ForceMipLevelsToBeResidentTimestamp = 0;

		private static uint __NumCinematicMipLevels = 0;

		private static uint __NoRefStreamingLODBias = 0;

		private static uint __StreamingIndex = 0;

		private static uint __NeverStream = 0;

		private static uint __bGlobalForceMipLevelsToBeResident = 0;

		private static uint __bHasStreamingUpdatePending = 0;

		private static uint __bForceMiplevelsToBeResident = 0;

		private static uint __bIgnoreStreamingMipBias = 0;

		private static uint __bUseCinematicMipLevels = 0;

		private static uint __SetForceMipLevelsToBeResident = 0;
	}
}