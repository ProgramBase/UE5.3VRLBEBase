using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaTexture")]
	public partial class UMediaTexture : UTexture, IStaticClass
	{
		public TextureAddress AddressX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AddressX, __ReturnBuffer);

					return *(TextureAddress*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AddressX, __InBuffer);
				}
			}
		}

		public TextureAddress AddressY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AddressY, __ReturnBuffer);

					return *(TextureAddress*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AddressY, __InBuffer);
				}
			}
		}

		public bool AutoClear
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoClear, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoClear, __InBuffer);
				}
			}
		}

		public FLinearColor ClearColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClearColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClearColor, __InBuffer);
				}
			}
		}

		public bool EnableGenMips
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnableGenMips, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnableGenMips, __InBuffer);
				}
			}
		}

		public byte NumMips
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumMips, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumMips, __InBuffer);
				}
			}
		}

		public bool NewStyleOutput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NewStyleOutput, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NewStyleOutput, __InBuffer);
				}
			}
		}

		public MediaTextureOutputFormat OutputFormat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OutputFormat, __ReturnBuffer);

					return *(MediaTextureOutputFormat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OutputFormat, __InBuffer);
				}
			}
		}

		public float CurrentAspectRatio
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentAspectRatio, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentAspectRatio, __InBuffer);
				}
			}
		}

		public MediaTextureOrientation CurrentOrientation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentOrientation, __ReturnBuffer);

					return *(MediaTextureOrientation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentOrientation, __InBuffer);
				}
			}
		}

		public UMediaPlayer MediaPlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MediaPlayer, __ReturnBuffer);

					return *(UMediaPlayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MediaPlayer, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaAssets.MediaTexture");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UpdateResource()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UpdateResource);
			}
		}

		/// <param name="NewMediaPlayer">
		/// The player to set.
		/// </param>
		/// <see>
		/// GetMediaPlayer
		/// </see>
		public virtual void SetMediaPlayer(UMediaPlayer NewMediaPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewMediaPlayer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMediaPlayer, __InBuffer);
			}
		}

		/// <see>
		/// GetAspectRatio, GetHeight
		/// </see>
		/// <returns>
		/// Texture width (in pixels).
		/// </returns>
		public virtual int GetWidth()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetWidth, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Number of mips.
		/// </returns>
		public virtual int GetTextureNumMips()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTextureNumMips, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <see>
		/// SetMediaPlayer
		/// </see>
		/// <returns>
		/// The texture's media player, or nullptr if not set.
		/// </returns>
		public virtual UMediaPlayer GetMediaPlayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMediaPlayer, __ReturnBuffer);

				return *(UMediaPlayer*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetAspectRatio, GetWidth
		/// </see>
		/// <returns>
		/// Texture height (in pixels).
		/// </returns>
		public virtual int GetHeight()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetHeight, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetHeight, GetWidth
		/// </see>
		/// <returns>
		/// Texture aspect ratio.
		/// </returns>
		public virtual float GetAspectRatio()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAspectRatio, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __AddressX = 0;

		private static uint __AddressY = 0;

		private static uint __AutoClear = 0;

		private static uint __ClearColor = 0;

		private static uint __EnableGenMips = 0;

		private static uint __NumMips = 0;

		private static uint __NewStyleOutput = 0;

		private static uint __OutputFormat = 0;

		private static uint __CurrentAspectRatio = 0;

		private static uint __CurrentOrientation = 0;

		private static uint __MediaPlayer = 0;

		private static uint __UpdateResource = 0;

		private static uint __SetMediaPlayer = 0;

		private static uint __GetWidth = 0;

		private static uint __GetTextureNumMips = 0;

		private static uint __GetMediaPlayer = 0;

		private static uint __GetHeight = 0;

		private static uint __GetAspectRatio = 0;
	}
}