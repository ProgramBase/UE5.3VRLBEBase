using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.MovieScene;

namespace Script.SequencerScripting
{
	[PathName("/Script/SequencerScripting.MovieSceneFolderExtensions")]
	public partial class UMovieSceneFolderExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerScripting.MovieSceneFolderExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Folder">
		/// The folder to set the name of
		/// </param>
		/// <param name="InFolderName">
		/// The new name for the folder
		/// </param>
		/// <returns>
		/// True if the setting of the folder name succeeds
		/// </returns>
		public static bool SetFolderName(UMovieSceneFolder Folder, FName InFolderName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InFolderName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetFolderName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Folder">
		/// The folder to set the display color of
		/// </param>
		/// <param name="InFolderColor">
		/// The new display color for the folder
		/// </param>
		/// <returns>
		/// True if the folder's display color is set successfully
		/// </returns>
		public static bool SetFolderColor(UMovieSceneFolder Folder, FColor InFolderColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InFolderColor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetFolderColor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Folder">
		/// The folder from which to remove a track
		/// </param>
		/// <param name="InTrack">
		/// The track to remove
		/// </param>
		/// <returns>
		/// True if the removal succeeds
		/// </returns>
		public static bool RemoveChildTrack(UMovieSceneFolder Folder, UMovieSceneTrack InTrack)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTrack?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveChildTrack, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Folder">
		/// The folder from which to remove an object binding
		/// </param>
		/// <param name="InObjectBinding">
		/// The object binding to remove
		/// </param>
		/// <returns>
		/// True if the operation succeeds
		/// </returns>
		public static bool RemoveChildObjectBinding(UMovieSceneFolder Folder, FMovieSceneBindingProxy InObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveChildObjectBinding, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool RemoveChildMasterTrack(UMovieSceneFolder Folder, UMovieSceneTrack InTrack)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTrack?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveChildMasterTrack, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetFolder">
		/// The folder from which to remove a child folder
		/// </param>
		/// <param name="FolderToRemove">
		/// The child folder to be removed
		/// </param>
		/// <returns>
		/// True if the removal succeeds
		/// </returns>
		public static bool RemoveChildFolder(UMovieSceneFolder TargetFolder, UMovieSceneFolder FolderToRemove)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetFolder?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FolderToRemove?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveChildFolder, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Folder">
		/// The folder to use
		/// </param>
		/// <returns>
		/// The target folder's name
		/// </returns>
		public static FName GetFolderName(UMovieSceneFolder Folder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetFolderName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="Folder">
		/// The folder to get the display color of
		/// </param>
		/// <returns>
		/// The display color of the given folder
		/// </returns>
		public static FColor GetFolderColor(UMovieSceneFolder Folder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetFolderColor, __InBuffer, __ReturnBuffer);

				return *(FColor*)__ReturnBuffer;
			}
		}

		/// <param name="Folder">
		/// The folder to get the tracks of
		/// </param>
		/// <returns>
		/// The tracks under the given folder
		/// </returns>
		public static TArray<UMovieSceneTrack> GetChildTracks(UMovieSceneFolder Folder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetChildTracks, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		/// <param name="Folder">
		/// The folder to get the bindings of
		/// </param>
		/// <returns>
		/// The object bindings under the given folder
		/// </returns>
		public static TArray<FMovieSceneBindingProxy> GetChildObjectBindings(UMovieSceneFolder Folder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetChildObjectBindings, __InBuffer, __ReturnBuffer);

				return *(TArray<FMovieSceneBindingProxy>*)__ReturnBuffer;
			}
		}

		public static TArray<UMovieSceneTrack> GetChildMasterTracks(UMovieSceneFolder Folder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetChildMasterTracks, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
			}
		}

		/// <param name="Folder">
		/// The folder to get the child folders of
		/// </param>
		/// <returns>
		/// The child folders associated with the given folder
		/// </returns>
		public static TArray<UMovieSceneFolder> GetChildFolders(UMovieSceneFolder Folder)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetChildFolders, __InBuffer, __ReturnBuffer);

				return *(TArray<UMovieSceneFolder>*)__ReturnBuffer;
			}
		}

		/// <param name="Folder">
		/// The folder to add a child track to
		/// </param>
		/// <param name="InTrack">
		/// The track to add to the folder
		/// </param>
		/// <returns>
		/// True if the addition is successful
		/// </returns>
		public static bool AddChildTrack(UMovieSceneFolder Folder, UMovieSceneTrack InTrack)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTrack?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddChildTrack, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Folder">
		/// The folder to add a child object to
		/// </param>
		/// <param name="InObjectBinding">
		/// The binding to add to the folder
		/// </param>
		/// <returns>
		/// True if the addition is successful
		/// </returns>
		public static bool AddChildObjectBinding(UMovieSceneFolder Folder, FMovieSceneBindingProxy InObjectBinding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InObjectBinding?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddChildObjectBinding, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool AddChildMasterTrack(UMovieSceneFolder Folder, UMovieSceneTrack InTrack)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Folder?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTrack?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddChildMasterTrack, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TargetFolder">
		/// The folder to add a child folder to
		/// </param>
		/// <param name="FolderToAdd">
		/// The child folder to be added
		/// </param>
		/// <returns>
		/// True if the addition is successful
		/// </returns>
		public static bool AddChildFolder(UMovieSceneFolder TargetFolder, UMovieSceneFolder FolderToAdd)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetFolder?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FolderToAdd?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __AddChildFolder, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetFolderName = 0;

		private static uint __SetFolderColor = 0;

		private static uint __RemoveChildTrack = 0;

		private static uint __RemoveChildObjectBinding = 0;

		private static uint __RemoveChildMasterTrack = 0;

		private static uint __RemoveChildFolder = 0;

		private static uint __GetFolderName = 0;

		private static uint __GetFolderColor = 0;

		private static uint __GetChildTracks = 0;

		private static uint __GetChildObjectBindings = 0;

		private static uint __GetChildMasterTracks = 0;

		private static uint __GetChildFolders = 0;

		private static uint __AddChildTrack = 0;

		private static uint __AddChildObjectBinding = 0;

		private static uint __AddChildMasterTrack = 0;

		private static uint __AddChildFolder = 0;
	}
}