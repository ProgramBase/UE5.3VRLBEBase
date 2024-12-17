using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GameplayTags
{
	[PathName("/Script/GameplayTags.BlueprintGameplayTagLibrary")]
	public partial class UBlueprintGameplayTagLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayTags.BlueprintGameplayTagLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InOutTagContainer">
		/// The container that will be appended too.
		/// </param>
		/// <param name="Tag">
		/// The tag to add to the container
		/// </param>
		public static bool RemoveGameplayTag(ref FGameplayTagContainer TagContainer, FGameplayTag Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TagContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __RemoveGameplayTag, __InBuffer, __OutBuffer, __ReturnBuffer);

				TagContainer = *(FGameplayTagContainer*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_TagTag(FGameplayTag A, FString B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_TagTag, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_TagContainerTagContainer(FGameplayTagContainer A, FString B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_TagContainerTagContainer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_GameplayTagContainer(FGameplayTagContainer A, FGameplayTagContainer B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_GameplayTagContainer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_GameplayTag(FGameplayTag A, FGameplayTag B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_GameplayTag, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TagOne">
		/// Tag to check for match
		/// </param>
		/// <param name="TagTwo">
		/// Tag to check match against
		/// </param>
		/// <param name="bExactMatch">
		/// If true, the tag has to be exactly present, if false then TagOne will include it's parent tags while matching			
		/// </param>
		/// <returns>
		/// True if TagOne matches TagTwo
		/// </returns>
		public static bool MatchesTag(FGameplayTag TagOne, FGameplayTag TagTwo, bool bExactMatch)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = TagOne?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TagTwo?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bExactMatch;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MatchesTag, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TagOne">
		/// Tag to check for match
		/// </param>
		/// <param name="OtherContainer">
		/// Container to check against.
		/// </param>
		/// <param name="bExactMatch">
		/// If true, the tag has to be exactly present, if false then TagOne will include it's parent tags while matching
		/// </param>
		/// <returns>
		/// True if TagOne matches any tags explicitly present in OtherContainer
		/// </returns>
		public static bool MatchesAnyTags(FGameplayTag TagOne, FGameplayTagContainer OtherContainer, bool bExactMatch)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = TagOne?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bExactMatch;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MatchesAnyTags, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FGameplayTagContainer MakeLiteralGameplayTagContainer(FGameplayTagContainer Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeLiteralGameplayTagContainer, __InBuffer, __ReturnBuffer);

				return *(FGameplayTagContainer*)__ReturnBuffer;
			}
		}

		public static FGameplayTag MakeLiteralGameplayTag(FGameplayTag Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeLiteralGameplayTag, __InBuffer, __ReturnBuffer);

				return *(FGameplayTag*)__ReturnBuffer;
			}
		}

		/// <param name="InTags">
		/// value to set the FGameplayTagQuery expression
		/// </param>
		/// <returns>
		/// The literal FGameplayTagQuery
		/// </returns>
		public static FGameplayTagQuery MakeGameplayTagQuery_MatchNoTags(FGameplayTagContainer InTags)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTags?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeGameplayTagQuery_MatchNoTags, __InBuffer, __ReturnBuffer);

				return *(FGameplayTagQuery*)__ReturnBuffer;
			}
		}

		/// <param name="InTags">
		/// value to set the FGameplayTagQuery expression
		/// </param>
		/// <returns>
		/// The literal FGameplayTagQuery
		/// </returns>
		public static FGameplayTagQuery MakeGameplayTagQuery_MatchAnyTags(FGameplayTagContainer InTags)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTags?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeGameplayTagQuery_MatchAnyTags, __InBuffer, __ReturnBuffer);

				return *(FGameplayTagQuery*)__ReturnBuffer;
			}
		}

		/// <param name="InTags">
		/// value to set the FGameplayTagQuery expression
		/// </param>
		/// <returns>
		/// The literal FGameplayTagQuery
		/// </returns>
		public static FGameplayTagQuery MakeGameplayTagQuery_MatchAllTags(FGameplayTagContainer InTags)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTags?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeGameplayTagQuery_MatchAllTags, __InBuffer, __ReturnBuffer);

				return *(FGameplayTagQuery*)__ReturnBuffer;
			}
		}

		/// <param name="TagQuery">
		/// value to set the FGameplayTagQuery to
		/// </param>
		/// <returns>
		/// The literal FGameplayTagQuery
		/// </returns>
		public static FGameplayTagQuery MakeGameplayTagQuery(FGameplayTagQuery TagQuery)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TagQuery?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeGameplayTagQuery, __InBuffer, __ReturnBuffer);

				return *(FGameplayTagQuery*)__ReturnBuffer;
			}
		}

		public static FGameplayTagContainer MakeGameplayTagContainerFromTag(FGameplayTag SingleTag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SingleTag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeGameplayTagContainerFromTag, __InBuffer, __ReturnBuffer);

				return *(FGameplayTagContainer*)__ReturnBuffer;
			}
		}

		public static FGameplayTagContainer MakeGameplayTagContainerFromArray(TArray<FGameplayTag> GameplayTags)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GameplayTags?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeGameplayTagContainerFromArray, __InBuffer, __ReturnBuffer);

				return *(FGameplayTagContainer*)__ReturnBuffer;
			}
		}

		/// <param name="TagQuery">
		/// Query to check
		/// </param>
		/// <returns>
		/// True if the query is empty, false otherwise.
		/// </returns>
		public static bool IsTagQueryEmpty(FGameplayTagQuery TagQuery)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TagQuery?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsTagQueryEmpty, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsGameplayTagValid(FGameplayTag GameplayTag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GameplayTag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsGameplayTagValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TagContainer">
		/// Container to check for the tag
		/// </param>
		/// <param name="Tag">
		/// Tag to check for in the container
		/// </param>
		/// <param name="bExactMatch">
		/// If true, the tag has to be exactly present, if false then TagContainer will include it's parent tags while matching			
		/// </param>
		/// <returns>
		/// True if the container has the specified tag, false if it does not
		/// </returns>
		public static bool HasTag(FGameplayTagContainer TagContainer, FGameplayTag Tag, bool bExactMatch)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = TagContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bExactMatch;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasTag, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TagContainer">
		/// Container to check if it matches any of the tags in the other container
		/// </param>
		/// <param name="OtherContainer">
		/// Container to check against.
		/// </param>
		/// <param name="bExactMatch">
		/// If true, the tag has to be exactly present, if false then TagContainer will include it's parent tags while matching			
		/// </param>
		/// <returns>
		/// True if the container has ANY of the tags in the other container
		/// </returns>
		public static bool HasAnyTags(FGameplayTagContainer TagContainer, FGameplayTagContainer OtherContainer, bool bExactMatch)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = TagContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bExactMatch;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasAnyTags, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TagContainer">
		/// Container to check if it matches all of the tags in the other container
		/// </param>
		/// <param name="OtherContainer">
		/// Container to check against. If this is empty, the check will succeed
		/// </param>
		/// <param name="bExactMatch">
		/// If true, the tag has to be exactly present, if false then TagContainer will include it's parent tags while matching			
		/// </param>
		/// <returns>
		/// True if the container has ALL of the tags in the other container
		/// </returns>
		public static bool HasAllTags(FGameplayTagContainer TagContainer, FGameplayTagContainer OtherContainer, bool bExactMatch)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = TagContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bExactMatch;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasAllTags, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TagContainerInterface">
		/// An Interface to a tag container
		/// </param>
		/// <param name="OtherContainer">
		/// A Tag Container
		/// </param>
		/// <returns>
		/// True if the tagcontainer in the interface has all the tags inside the container.
		/// </returns>
		public static bool HasAllMatchingGameplayTags(TScriptInterface<IGameplayTagAssetInterface> TagContainerInterface, FGameplayTagContainer OtherContainer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TagContainerInterface?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherContainer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasAllMatchingGameplayTags, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FName GetTagName(FGameplayTag GameplayTag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GameplayTag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTagName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="TagContainer">
		/// Tag container to get the number of tags from
		/// </param>
		/// <returns>
		/// The number of tags in the specified container
		/// </returns>
		public static int GetNumGameplayTagsInContainer(FGameplayTagContainer TagContainer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TagContainer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNumGameplayTagsInContainer, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="TagContainer">
		/// The tag container to get the debug string from.
		/// </param>
		public static FString GetDebugStringFromGameplayTagContainer(FGameplayTagContainer TagContainer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TagContainer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDebugStringFromGameplayTagContainer, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="GameplayTag">
		/// The tag to get the debug string from.
		/// </param>
		public static FString GetDebugStringFromGameplayTag(FGameplayTag GameplayTag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = GameplayTag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDebugStringFromGameplayTag, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="ActorClass">
		/// Class of actors to fetch
		/// </param>
		/// <param name="GameplayTagQuery">
		/// Query to match against
		/// </param>
		public static void GetAllActorsOfClassMatchingTagQuery(UObject WorldContextObject, TSubclassOf<AActor> ActorClass, FGameplayTagQuery GameplayTagQuery, ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActorClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = GameplayTagQuery?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAllActorsOfClassMatchingTagQuery, __InBuffer, __OutBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		public static bool EqualEqual_GameplayTagContainer(FGameplayTagContainer A, FGameplayTagContainer B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_GameplayTagContainer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_GameplayTag(FGameplayTag A, FGameplayTag B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_GameplayTag, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TagContainerInterface">
		/// An Interface to a tag container
		/// </param>
		/// <param name="Tag">
		/// Tag to check for in the container
		/// </param>
		/// <returns>
		/// True if the container has the specified tag, false if it does not
		/// </returns>
		public static bool DoesTagAssetInterfaceHaveTag(TScriptInterface<IGameplayTagAssetInterface> TagContainerInterface, FGameplayTag Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TagContainerInterface?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DoesTagAssetInterfaceHaveTag, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="TagContainer">
		/// Container to check if it matches all of the tags in the other container
		/// </param>
		/// <param name="TagQuery">
		/// Query to match against
		/// </param>
		/// <returns>
		/// True if the container matches the query, false otherwise.
		/// </returns>
		public static bool DoesContainerMatchTagQuery(FGameplayTagContainer TagContainer, FGameplayTagQuery TagQuery)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TagContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TagQuery?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DoesContainerMatchTagQuery, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void BreakGameplayTagContainer(FGameplayTagContainer GameplayTagContainer, ref TArray<FGameplayTag> GameplayTags)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = GameplayTagContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GameplayTags?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakGameplayTagContainer, __InBuffer, __OutBuffer);

				GameplayTags = *(TArray<FGameplayTag>*)(__OutBuffer);

			}
		}

		/// <param name="InOutTagContainer">
		/// The container that will be appended too.
		/// </param>
		/// <param name="InTagContainer">
		/// The container to append.
		/// </param>
		public static void AppendGameplayTagContainers(ref FGameplayTagContainer InOutTagContainer, FGameplayTagContainer InTagContainer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InOutTagContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTagContainer?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __AppendGameplayTagContainers, __InBuffer, __OutBuffer);

				InOutTagContainer = *(FGameplayTagContainer*)(__OutBuffer);

			}
		}

		/// <param name="InOutTagContainer">
		/// The container that will be appended too.
		/// </param>
		/// <param name="Tag">
		/// The tag to add to the container
		/// </param>
		public static void AddGameplayTag(ref FGameplayTagContainer TagContainer, FGameplayTag Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TagContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __AddGameplayTag, __InBuffer, __OutBuffer);

				TagContainer = *(FGameplayTagContainer*)(__OutBuffer);

			}
		}

		private static uint __RemoveGameplayTag = 0;

		private static uint __NotEqual_TagTag = 0;

		private static uint __NotEqual_TagContainerTagContainer = 0;

		private static uint __NotEqual_GameplayTagContainer = 0;

		private static uint __NotEqual_GameplayTag = 0;

		private static uint __MatchesTag = 0;

		private static uint __MatchesAnyTags = 0;

		private static uint __MakeLiteralGameplayTagContainer = 0;

		private static uint __MakeLiteralGameplayTag = 0;

		private static uint __MakeGameplayTagQuery_MatchNoTags = 0;

		private static uint __MakeGameplayTagQuery_MatchAnyTags = 0;

		private static uint __MakeGameplayTagQuery_MatchAllTags = 0;

		private static uint __MakeGameplayTagQuery = 0;

		private static uint __MakeGameplayTagContainerFromTag = 0;

		private static uint __MakeGameplayTagContainerFromArray = 0;

		private static uint __IsTagQueryEmpty = 0;

		private static uint __IsGameplayTagValid = 0;

		private static uint __HasTag = 0;

		private static uint __HasAnyTags = 0;

		private static uint __HasAllTags = 0;

		private static uint __HasAllMatchingGameplayTags = 0;

		private static uint __GetTagName = 0;

		private static uint __GetNumGameplayTagsInContainer = 0;

		private static uint __GetDebugStringFromGameplayTagContainer = 0;

		private static uint __GetDebugStringFromGameplayTag = 0;

		private static uint __GetAllActorsOfClassMatchingTagQuery = 0;

		private static uint __EqualEqual_GameplayTagContainer = 0;

		private static uint __EqualEqual_GameplayTag = 0;

		private static uint __DoesTagAssetInterfaceHaveTag = 0;

		private static uint __DoesContainerMatchTagQuery = 0;

		private static uint __BreakGameplayTagContainer = 0;

		private static uint __AppendGameplayTagContainers = 0;

		private static uint __AddGameplayTag = 0;
	}
}