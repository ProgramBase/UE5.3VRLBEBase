using Script.CoreUObject;
using Script.Library;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaPlaylist")]
	public partial class UMediaPlaylist : UObject, IStaticClass
	{
		public TArray<UMediaSource> Items
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Items, __ReturnBuffer);

					return *(TArray<UMediaSource>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Items, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaAssets.MediaPlaylist");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Index">
		/// The index of the media source to replace.
		/// </param>
		/// <param name="Replacement">
		/// The replacement media source.
		/// </param>
		/// <see>
		/// Add, Insert, RemoveAll, RemoveAt
		/// </see>
		/// <returns>
		/// true if the media source was replaced, false otherwise.
		/// </returns>
		public virtual bool Replace(int Index, UMediaSource Replacement)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(nint*)(__InBuffer + 4) = Replacement?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Replace, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Index">
		/// The index of the media source to remove.
		/// </param>
		/// <see>
		/// Add, Insert, RemoveAll, Replace
		/// </see>
		/// <returns>
		/// true if the media source was removed, false otherwise.
		/// </returns>
		public virtual bool RemoveAt(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAt, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="MediaSource">
		/// The media source to remove.
		/// </param>
		/// <see>
		/// Add, Insert, Remove, Replace
		/// </see>
		/// <returns>
		/// true if the media source was removed, false otherwise.
		/// </returns>
		public virtual bool Remove(UMediaSource MediaSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MediaSource?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Remove, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Number of media sources.
		/// </returns>
		public virtual int Num()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Num, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="MediaSource">
		/// The media source to insert.
		/// </param>
		/// <param name="Index">
		/// The index to insert into.
		/// </param>
		/// <see>
		/// Add, Remove, RemoveAll, Replace
		/// </see>
		public virtual void Insert(UMediaSource MediaSource, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = MediaSource?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Insert, __InBuffer);
			}
		}

		/// <param name="OutIndex">
		/// Will contain the index of the returned media source.
		/// </param>
		/// <see>
		/// Get, GetNext, GetPrevious
		/// </see>
		/// <returns>
		/// The random media source, or nullptr if the list is empty.
		/// </returns>
		public virtual UMediaSource GetRandom(ref int OutIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = OutIndex;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __GetRandom, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutIndex = *(int*)(__OutBuffer);

				return *(UMediaSource*)__ReturnBuffer;
			}
		}

		/// <param name="InOutIndex">
		/// Index of the current media source (will contain the new index).
		/// </param>
		/// <see>
		/// , GetNext, GetRandom
		/// </see>
		/// <returns>
		/// The media source before the current one, or nullptr if the list is empty.
		/// </returns>
		public virtual UMediaSource GetPrevious(ref int InOutIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InOutIndex;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __GetPrevious, __InBuffer, __OutBuffer, __ReturnBuffer);

				InOutIndex = *(int*)(__OutBuffer);

				return *(UMediaSource*)__ReturnBuffer;
			}
		}

		/// <param name="InOutIndex">
		/// Index of the current media source (will contain the new index).
		/// </param>
		/// <see>
		/// , GetPrevious, GetRandom
		/// </see>
		/// <returns>
		/// The media source after the current one, or nullptr if the list is empty.
		/// </returns>
		public virtual UMediaSource GetNext(ref int InOutIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InOutIndex;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __GetNext, __InBuffer, __OutBuffer, __ReturnBuffer);

				InOutIndex = *(int*)(__OutBuffer);

				return *(UMediaSource*)__ReturnBuffer;
			}
		}

		/// <param name="Index">
		/// The index of the media source to get.
		/// </param>
		/// <see>
		/// GetNext, GetRandom
		/// </see>
		/// <returns>
		/// The media source, or nullptr if the index doesn't exist.
		/// </returns>
		public virtual UMediaSource Get(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __Get, __InBuffer, __ReturnBuffer);

				return *(UMediaSource*)__ReturnBuffer;
			}
		}

		/// <param name="Url">
		/// The URL to add.
		/// </param>
		/// <see>
		/// Add, AddFile, Insert, RemoveAll, Remove, Replace
		/// </see>
		/// <returns>
		/// true if the URL was added, false otherwise.
		/// </returns>
		public virtual bool AddUrl(FString Url)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Url?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddUrl, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="FilePath">
		/// The file path to add.
		/// </param>
		/// <see>
		/// Add, AddUrl, Insert, RemoveAll, Remove, Replace
		/// </see>
		/// <returns>
		/// true if the file was added, false otherwise.
		/// </returns>
		public virtual bool AddFile(FString FilePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = FilePath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="MediaSource">
		/// The media source to append.
		/// </param>
		/// <see>
		/// AddFile, AddUrl, Insert, RemoveAll, Remove, Replace
		/// </see>
		/// <returns>
		/// true if the media source was added, false otherwise.
		/// </returns>
		public virtual bool Add(UMediaSource MediaSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MediaSource?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __Add, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Items = 0;

		private static uint __Replace = 0;

		private static uint __RemoveAt = 0;

		private static uint __Remove = 0;

		private static uint __Num = 0;

		private static uint __Insert = 0;

		private static uint __GetRandom = 0;

		private static uint __GetPrevious = 0;

		private static uint __GetNext = 0;

		private static uint __Get = 0;

		private static uint __AddUrl = 0;

		private static uint __AddFile = 0;

		private static uint __Add = 0;
	}
}