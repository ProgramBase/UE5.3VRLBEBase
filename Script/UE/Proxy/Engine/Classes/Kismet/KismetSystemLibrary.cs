using Script.CoreUObject;
using Script.Library;
using Script.Engine.KismetSystemLibrary;
using Script.Reflection.Property;

namespace Script.Engine
{
	[PathName("/Script/Engine.KismetSystemLibrary")]
	public partial class UKismetSystemLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.KismetSystemLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void UnregisterForRemoteNotifications()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __UnregisterForRemoteNotifications);
			}
		}

		public static void UnloadPrimaryAssetList(TArray<FPrimaryAssetId> PrimaryAssetIdList)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrimaryAssetIdList?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __UnloadPrimaryAssetList, __InBuffer);
			}
		}

		public static void UnloadPrimaryAsset(FPrimaryAssetId PrimaryAssetId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrimaryAssetId?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __UnloadPrimaryAsset, __InBuffer);
			}
		}

		/// <note>
		/// Internally this calls Modify on the given object, so will also mark the owner package dirty.
		/// </note>
		/// <note>
		/// Only available in the editor.
		/// </note>
		/// <param name="Object">
		/// The object that is about to be modified.
		/// </param>
		public static void TransactObject(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __TransactObject, __InBuffer);
			}
		}

		public static void StackTrace()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __StackTrace);
			}
		}

		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Radius">
		/// Radius of the sphere to sweep
		/// </param>
		/// <param name="ObjectTypes">
		/// Array of Object Types to trace 
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool SphereTraceSingleForObjects(UObject WorldContextObject, FVector Start, FVector End, float Radius, TArray<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[75];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(nint*)(__InBuffer + 28) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 36) = bTraceComplex;

				*(nint*)(__InBuffer + 37) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 45) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 46) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 54) = bIgnoreSelf;

				*(nint*)(__InBuffer + 55) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 63) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 71) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __SphereTraceSingleForObjects, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Radius">
		/// Radius of the sphere to sweep
		/// </param>
		/// <param name="ProfileName">
		/// The 'profile' used to determine which components to hit
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool SphereTraceSingleByProfile(UObject WorldContextObject, FVector Start, FVector End, float Radius, FName ProfileName, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[75];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(nint*)(__InBuffer + 28) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 36) = bTraceComplex;

				*(nint*)(__InBuffer + 37) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 45) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 46) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 54) = bIgnoreSelf;

				*(nint*)(__InBuffer + 55) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 63) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 71) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __SphereTraceSingleByProfile, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Radius">
		/// Radius of the sphere to sweep
		/// </param>
		/// <param name="TraceChannel">
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool SphereTraceSingle(UObject WorldContextObject, FVector Start, FVector End, float Radius, ETraceTypeQuery TraceChannel, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[68];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(byte*)(__InBuffer + 28) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 29) = bTraceComplex;

				*(nint*)(__InBuffer + 30) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 38) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 39) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 47) = bIgnoreSelf;

				*(nint*)(__InBuffer + 48) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 56) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 64) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __SphereTraceSingle, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Radius">
		/// Radius of the sphere to sweep
		/// </param>
		/// <param name="ObjectTypes">
		/// Array of Object Types to trace 
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHits">
		/// A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool SphereTraceMultiForObjects(UObject WorldContextObject, FVector Start, FVector End, float Radius, TArray<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[75];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(nint*)(__InBuffer + 28) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 36) = bTraceComplex;

				*(nint*)(__InBuffer + 37) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 45) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 46) = OutHits?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 54) = bIgnoreSelf;

				*(nint*)(__InBuffer + 55) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 63) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 71) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __SphereTraceMultiForObjects, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHits = *(TArray<FHitResult>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Radius">
		/// Radius of the sphere to sweep
		/// </param>
		/// <param name="ProfileName">
		/// The 'profile' used to determine which components to hit
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHits">
		/// A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
		/// </param>
		/// <returns>
		/// True if there was a blocking hit, false otherwise.
		/// </returns>
		public static bool SphereTraceMultiByProfile(UObject WorldContextObject, FVector Start, FVector End, float Radius, FName ProfileName, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[75];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(nint*)(__InBuffer + 28) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 36) = bTraceComplex;

				*(nint*)(__InBuffer + 37) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 45) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 46) = OutHits?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 54) = bIgnoreSelf;

				*(nint*)(__InBuffer + 55) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 63) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 71) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __SphereTraceMultiByProfile, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHits = *(TArray<FHitResult>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Radius">
		/// Radius of the sphere to sweep
		/// </param>
		/// <param name="TraceChannel">
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHits">
		/// A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
		/// </param>
		/// <returns>
		/// True if there was a blocking hit, false otherwise.
		/// </returns>
		public static bool SphereTraceMulti(UObject WorldContextObject, FVector Start, FVector End, float Radius, ETraceTypeQuery TraceChannel, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[68];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(byte*)(__InBuffer + 28) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 29) = bTraceComplex;

				*(nint*)(__InBuffer + 30) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 38) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 39) = OutHits?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 47) = bIgnoreSelf;

				*(nint*)(__InBuffer + 48) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 56) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 64) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __SphereTraceMulti, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHits = *(TArray<FHitResult>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="SpherePos">
		/// Center of sphere.
		/// </param>
		/// <param name="SphereRadius">
		/// Size of sphere.
		/// </param>
		/// <param name="Filter">
		/// Option to restrict results to only static or only dynamic.  For efficiency.
		/// </param>
		/// <param name="ClassFilter">
		/// If set, will only return results of this class or subclasses of it.
		/// </param>
		/// <param name="ActorsToIgnore">
		/// Ignore these actors in the list
		/// </param>
		/// <param name="OutActors">
		/// Returned array of actors. Unsorted.
		/// </param>
		/// <returns>
		/// true if there was an overlap that passed the filters, false otherwise.
		/// </returns>
		public static bool SphereOverlapComponents(UObject WorldContextObject, FVector SpherePos, float SphereRadius, TArray<EObjectTypeQuery> ObjectTypes, UClass ComponentClassFilter, TArray<AActor> ActorsToIgnore, ref TArray<UPrimitiveComponent> OutComponents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[52];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SpherePos?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = SphereRadius;

				*(nint*)(__InBuffer + 20) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = ComponentClassFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = OutComponents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __SphereOverlapComponents, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutComponents = *(TArray<UPrimitiveComponent>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="SpherePos">
		/// Center of sphere.
		/// </param>
		/// <param name="SphereRadius">
		/// Size of sphere.
		/// </param>
		/// <param name="Filter">
		/// Option to restrict results to only static or only dynamic.  For efficiency.
		/// </param>
		/// <param name="ClassFilter">
		/// If set, will only return results of this class or subclasses of it.
		/// </param>
		/// <param name="ActorsToIgnore">
		/// Ignore these actors in the list
		/// </param>
		/// <param name="OutActors">
		/// Returned array of actors. Unsorted.
		/// </param>
		/// <returns>
		/// true if there was an overlap that passed the filters, false otherwise.
		/// </returns>
		public static bool SphereOverlapActors(UObject WorldContextObject, FVector SpherePos, float SphereRadius, TArray<EObjectTypeQuery> ObjectTypes, UClass ActorClassFilter, TArray<AActor> ActorsToIgnore, ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[52];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SpherePos?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = SphereRadius;

				*(nint*)(__InBuffer + 20) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = ActorClassFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 36) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 44) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __SphereOverlapActors, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Internally this calls SnapshotTransactionBuffer on the given object.
		/// </note>
		/// <note>
		/// Only available in the editor.
		/// </note>
		/// <param name="Object">
		/// The object that is about to be modified.
		/// </param>
		public static void SnapshotObject(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SnapshotObject, __InBuffer);
			}
		}

		public static void ShowPlatformSpecificLeaderboardScreen(FString CategoryName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CategoryName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ShowPlatformSpecificLeaderboardScreen, __InBuffer);
			}
		}

		/// <param name="SpecificPlayer">
		/// Specific player's achievements to show. May not be supported on all platforms. If null, defaults to the player with ControllerId 0
		/// </param>
		public static void ShowPlatformSpecificAchievementsScreen(APlayerController SpecificPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SpecificPlayer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ShowPlatformSpecificAchievementsScreen, __InBuffer);
			}
		}

		public static void ShowInterstitialAd()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __ShowInterstitialAd);
			}
		}

		/// <param name="AdIdIndex">
		/// The index of the ID to select for the ad to show
		/// </param>
		/// <param name="bShowOnBottomOfScreen">
		/// If true, the iAd will be shown at the bottom of the screen, top otherwise
		/// </param>
		public static void ShowAdBanner(int AdIdIndex, bool bShowOnBottomOfScreen)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = AdIdIndex;

				*(bool*)(__InBuffer + 4) = bShowOnBottomOfScreen;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ShowAdBanner, __InBuffer);
			}
		}

		public static void SetWindowTitle(FText Title)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Title?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetWindowTitle, __InBuffer);
			}
		}

		/// <param name="bEnabled">
		/// If true, allow Android to handle volume up and down events
		/// </param>
		public static void SetVolumeButtonsHandledBySystem(bool bEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetVolumeButtonsHandledBySystem, __InBuffer);
			}
		}

		public static void SetVectorPropertyByName(UObject Object, FName PropertyName, FVector Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetVectorPropertyByName, __InBuffer);
			}
		}

		public static void SetVector3fPropertyByName(UObject Object, FName PropertyName, FVector3f Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetVector3fPropertyByName, __InBuffer);
			}
		}

		public static void SetUserActivity(FUserActivity UserActivity)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = UserActivity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetUserActivity, __InBuffer);
			}
		}

		public static void SetTransformPropertyByName(UObject Object, FName PropertyName, FTransform Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetTransformPropertyByName, __InBuffer);
			}
		}

		public static void SetTextPropertyByName(UObject Object, FName PropertyName, FText Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetTextPropertyByName, __InBuffer);
			}
		}

		/// <param name="WorldContextObject">
		/// World context
		/// </param>
		/// <param name="State">
		/// set true to suppress transition message
		/// </param>
		public static void SetSuppressViewportTransitionMessage(UObject WorldContextObject, bool bState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bState;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSuppressViewportTransitionMessage, __InBuffer);
			}
		}

		public static void SetStructurePropertyByName(UObject Object, FName PropertyName, FGenericStruct Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetStructurePropertyByName, __InBuffer);
			}
		}

		public static void SetStringPropertyByName(UObject Object, FName PropertyName, FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetStringPropertyByName, __InBuffer);
			}
		}

		public static void SetSoftObjectPropertyByName(UObject Object, FName PropertyName, TSoftObjectPtr<UObject> Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSoftObjectPropertyByName, __InBuffer);
			}
		}

		public static void SetSoftClassPropertyByName(UObject Object, FName PropertyName, TSoftClassPtr<UObject> Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetSoftClassPropertyByName, __InBuffer);
			}
		}

		public static void SetRotatorPropertyByName(UObject Object, FName PropertyName, FRotator Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetRotatorPropertyByName, __InBuffer);
			}
		}

		public static void SetObjectPropertyByName(UObject Object, FName PropertyName, UObject Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetObjectPropertyByName, __InBuffer);
			}
		}

		public static void SetNamePropertyByName(UObject Object, FName PropertyName, FName Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNamePropertyByName, __InBuffer);
			}
		}

		public static void SetLinearColorPropertyByName(UObject Object, FName PropertyName, FLinearColor Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetLinearColorPropertyByName, __InBuffer);
			}
		}

		public static void SetIntPropertyByName(UObject Object, FName PropertyName, int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetIntPropertyByName, __InBuffer);
			}
		}

		public static void SetInterfacePropertyByName(UObject Object, FName PropertyName, TScriptInterface<IInterface> Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetInterfacePropertyByName, __InBuffer);
			}
		}

		public static void SetInt64PropertyByName(UObject Object, FName PropertyName, long Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(long*)(__InBuffer + 16) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetInt64PropertyByName, __InBuffer);
			}
		}

		public static void SetGamepadsBlockDeviceFeedback(bool bBlock)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bBlock;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetGamepadsBlockDeviceFeedback, __InBuffer);
			}
		}

		public static void SetFieldPathPropertyByName(UObject Object, FName PropertyName, TFieldPath<FField> Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetFieldPathPropertyByName, __InBuffer);
			}
		}

		/// <param name="Object">
		/// The object you want to set a property value on.
		/// </param>
		/// <param name="PropertyName">
		/// The name of the object property to set the value of.
		/// </param>
		/// <param name="PropertyValue">
		/// The property value to set.
		/// </param>
		/// <param name="ChangeNotifyMode">
		/// When to emit property change notifications.
		/// </param>
		/// <returns>
		/// Whether the property value was found and correctly set.
		/// </returns>
		public static bool SetEditorProperty(UObject Object, FName PropertyName, int PropertyValue, EPropertyAccessChangeNotifyMode ChangeNotifyMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = PropertyValue;

				*(byte*)(__InBuffer + 20) = (byte)ChangeNotifyMode;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __SetEditorProperty, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void SetDoublePropertyByName(UObject Object, FName PropertyName, double Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 16) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetDoublePropertyByName, __InBuffer);
			}
		}

		public static void SetColorPropertyByName(UObject Object, FName PropertyName, FColor Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetColorPropertyByName, __InBuffer);
			}
		}

		public static void SetCollisionProfileNameProperty(UObject Object, FName PropertyName, FCollisionProfileName Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetCollisionProfileNameProperty, __InBuffer);
			}
		}

		public static void SetClassPropertyByName(UObject Object, FName PropertyName, TSubclassOf<UObject> Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetClassPropertyByName, __InBuffer);
			}
		}

		public static void SetBytePropertyByName(UObject Object, FName PropertyName, byte Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBytePropertyByName, __InBuffer);
			}
		}

		public static void SetBoolPropertyByName(UObject Object, FName PropertyName, bool Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBoolPropertyByName, __InBuffer);
			}
		}

		/// <param name="WorldContext">
		/// World context.
		/// </param>
		/// <param name="Duration">
		/// length of delay (in seconds).
		/// </param>
		/// <param name="LatentInfo">
		/// The latent action.
		/// </param>
		public static void RetriggerableDelay(UObject WorldContextObject, float Duration, FLatentActionInfo LatentInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Duration;

				*(nint*)(__InBuffer + 12) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RetriggerableDelay, __InBuffer);
			}
		}

		public static void ResetGamepadAssignmentToController(int ControllerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ControllerId;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ResetGamepadAssignmentToController, __InBuffer);
			}
		}

		public static void ResetGamepadAssignments()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __ResetGamepadAssignments);
			}
		}

		public static void RegisterForRemoteNotifications()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __RegisterForRemoteNotifications);
			}
		}

		/// <param name="SpecificPlayer">
		/// The specific player to quit the game. If not specified, player 0 will quit.
		/// </param>
		/// <param name="QuitPreference">
		/// Form of quitting.
		/// </param>
		/// <param name="bIgnorePlatformRestrictions">
		/// Ignores and best-practices based on platform (e.g on some consoles, games should never quit). Non-shipping only
		/// </param>
		public static void QuitGame(UObject WorldContextObject, APlayerController SpecificPlayer, EQuitPreference QuitPreference, bool bIgnorePlatformRestrictions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SpecificPlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)QuitPreference;

				*(bool*)(__InBuffer + 17) = bIgnorePlatformRestrictions;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __QuitGame, __InBuffer);
			}
		}

		public static void QuitEditor()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __QuitEditor);
			}
		}

		/// <param name="InString">
		/// The string to log out
		/// </param>
		public static void PrintWarning(FString InString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PrintWarning, __InBuffer);
			}
		}

		/// <param name="InText">
		/// The text to log out
		/// </param>
		/// <param name="bPrintToScreen">
		/// Whether or not to print the output to the screen
		/// </param>
		/// <param name="bPrintToLog">
		/// Whether or not to print the output to the log
		/// </param>
		/// <param name="bPrintToConsole">
		/// Whether or not to print the output to the console
		/// </param>
		/// <param name="TextColor">
		/// The color of the text to display
		/// </param>
		/// <param name="Duration">
		/// The display duration (if Print to Screen is True). Using negative number will result in loading the duration time from the config.
		/// </param>
		/// <param name="Key">
		/// If a non-empty key is provided, the message will replace any existing on-screen messages with the same key.
		/// </param>
		public static void PrintText(UObject WorldContextObject, FText InText = null, bool bPrintToScreen = true, bool bPrintToLog = true, FLinearColor TextColor = null, float Duration = 2.000000f, FName Key = null)
		{
			unsafe
			{
				InText ??= new FText("Hello");

				TextColor ??= new FLinearColor(0.000000f, 0.660000f, 1.000000f, 1.000000f);

				Key ??= new FName("None");

				var __InBuffer = stackalloc byte[38];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InText?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bPrintToScreen;

				*(bool*)(__InBuffer + 17) = bPrintToLog;

				*(nint*)(__InBuffer + 18) = TextColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 26) = Duration;

				*(nint*)(__InBuffer + 30) = Key?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PrintText, __InBuffer);
			}
		}

		/// <param name="InString">
		/// The string to log out
		/// </param>
		/// <param name="bPrintToScreen">
		/// Whether or not to print the output to the screen
		/// </param>
		/// <param name="bPrintToLog">
		/// Whether or not to print the output to the log
		/// </param>
		/// <param name="bPrintToConsole">
		/// Whether or not to print the output to the console
		/// </param>
		/// <param name="TextColor">
		/// The color of the text to display
		/// </param>
		/// <param name="Duration">
		/// The display duration (if Print to Screen is True). Using negative number will result in loading the duration time from the config.
		/// </param>
		/// <param name="Key">
		/// If a non-empty key is provided, the message will replace any existing on-screen messages with the same key.
		/// </param>
		public static void PrintString(UObject WorldContextObject, FString InString = null, bool bPrintToScreen = true, bool bPrintToLog = true, FLinearColor TextColor = null, float Duration = 2.000000f, FName Key = null)
		{
			unsafe
			{
				InString ??= new FString("Hello");

				TextColor ??= new FLinearColor(0.000000f, 0.660000f, 1.000000f, 1.000000f);

				Key ??= new FName("None");

				var __InBuffer = stackalloc byte[38];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InString?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bPrintToScreen;

				*(bool*)(__InBuffer + 17) = bPrintToLog;

				*(nint*)(__InBuffer + 18) = TextColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 26) = Duration;

				*(nint*)(__InBuffer + 30) = Key?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __PrintString, __InBuffer);
			}
		}

		public static bool ParseParamValue(FString InString, FString InParam, ref FString OutValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParam?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ParseParamValue, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool ParseParam(FString InString, FString InParam)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InParam?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ParseParam, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InCmdLine">
		/// The the string to parse (ie '-foo -bar=/game/baz testtoken' )
		/// </param>
		/// <param name="OutTokens">
		/// [out]		Filled with all loose tokens found in the string (ie: testToken in above example)
		/// </param>
		/// <param name="OutSwitches">
		/// [out]	Filled with all switches found in the string (ie -foo)
		/// </param>
		/// <param name="OutParams">
		/// [out]		Filled with all switches found in the string with the format key = value (ie: -bar, /game/baz)
		/// </param>
		public static void ParseCommandLine(FString InCmdLine, ref TArray<FString> OutTokens, ref TArray<FString> OutSwitches, ref TMap<FString, FString> OutParams)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InCmdLine?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutTokens?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutSwitches?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutParams?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __ParseCommandLine, __InBuffer, __OutBuffer);

				OutTokens = *(TArray<FString>*)(__OutBuffer);

				OutSwitches = *(TArray<FString>*)(__OutBuffer + 8);

				OutParams = *(TMap<FString, FString>*)(__OutBuffer + 16);

			}
		}

		public static bool NotEqual_SoftObjectReference(TSoftObjectPtr<UObject> A, TSoftObjectPtr<UObject> B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_SoftObjectReference, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_SoftClassReference(TSoftClassPtr<UObject> A, TSoftClassPtr<UObject> B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_SoftClassReference, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_PrimaryAssetType(FPrimaryAssetType A, FPrimaryAssetType B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_PrimaryAssetType, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool NotEqual_PrimaryAssetId(FPrimaryAssetId A, FPrimaryAssetId B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __NotEqual_PrimaryAssetId, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// </>
		/// to TEXT("/") */
		/// <//>
		public static FString NormalizeFilename(FString InFilename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFilename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __NormalizeFilename, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Component">
		/// Component to interpolate
		/// </param>
		/// <param name="TargetRelativeLocation">
		/// Relative target location
		/// </param>
		/// <param name="TargetRelativeRotation">
		/// Relative target rotation
		/// </param>
		/// <param name="bEaseOut">
		/// if true we will ease out (ie end slowly) during interpolation
		/// </param>
		/// <param name="bEaseIn">
		/// if true we will ease in (ie start slowly) during interpolation
		/// </param>
		/// <param name="OverTime">
		/// duration of interpolation
		/// </param>
		/// <param name="bForceShortestRotationPath">
		/// if true we will always use the shortest path for rotation
		/// </param>
		/// <param name="MoveAction">
		/// required movement behavior @see EMoveComponentAction
		/// </param>
		/// <param name="LatentInfo">
		/// The latent action
		/// </param>
		public static void MoveComponentTo(USceneComponent Component, FVector TargetRelativeLocation, FRotator TargetRelativeRotation, bool bEaseOut, bool bEaseIn, float OverTime, bool bForceShortestRotationPath, EMoveComponentAction MoveAction, FLatentActionInfo LatentInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetRelativeLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = TargetRelativeRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bEaseOut;

				*(bool*)(__InBuffer + 25) = bEaseIn;

				*(float*)(__InBuffer + 26) = OverTime;

				*(bool*)(__InBuffer + 30) = bForceShortestRotationPath;

				*(byte*)(__InBuffer + 31) = (byte)MoveAction;

				*(nint*)(__InBuffer + 32) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __MoveComponentTo, __InBuffer);
			}
		}

		public static FTopLevelAssetPath MakeTopLevelAssetPath(FString PackageName, FString AssetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeTopLevelAssetPath, __InBuffer, __ReturnBuffer);

				return *(FTopLevelAssetPath*)__ReturnBuffer;
			}
		}

		public static FSoftObjectPath MakeSoftObjectPath(FString PathString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PathString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeSoftObjectPath, __InBuffer, __ReturnBuffer);

				return *(FSoftObjectPath*)__ReturnBuffer;
			}
		}

		public static FSoftClassPath MakeSoftClassPath(FString PathString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PathString?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeSoftClassPath, __InBuffer, __ReturnBuffer);

				return *(FSoftClassPath*)__ReturnBuffer;
			}
		}

		/// <param name="Value">
		/// value to set the FText to
		/// </param>
		/// <returns>
		/// The literal FText
		/// </returns>
		public static FText MakeLiteralText(FText Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeLiteralText, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		/// <param name="Value">
		/// value to set the string to
		/// </param>
		/// <returns>
		/// The literal string
		/// </returns>
		public static FString MakeLiteralString(FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeLiteralString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Value">
		/// value to set the name to
		/// </param>
		/// <returns>
		/// The literal name
		/// </returns>
		public static FName MakeLiteralName(FName Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeLiteralName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="Value">
		/// value to set the 64-bit integer to
		/// </param>
		/// <returns>
		/// The literal 64-bit integer
		/// </returns>
		public static long MakeLiteralInt64(long Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(long*)(__InBuffer) = Value;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeLiteralInt64, __InBuffer, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		/// <param name="Value">
		/// value to set the integer to
		/// </param>
		/// <returns>
		/// The literal integer
		/// </returns>
		public static int MakeLiteralInt(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeLiteralInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Value">
		/// value to set the float (double-precision) to
		/// </param>
		/// <returns>
		/// The literal float (double-precision)
		/// </returns>
		public static double MakeLiteralDouble(double Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = Value;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeLiteralDouble, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		/// <param name="Value">
		/// value to set the byte to
		/// </param>
		/// <returns>
		/// The literal byte
		/// </returns>
		public static byte MakeLiteralByte(byte Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = Value;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeLiteralByte, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		/// <param name="Value">
		/// value to set the bool to
		/// </param>
		/// <returns>
		/// The literal bool
		/// </returns>
		public static bool MakeLiteralBool(bool Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = Value;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeLiteralBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="ClassNames">
		/// [DEPRECATED] - Class names are now represented by path names. If non-empty, this input will result in a runtime warning. Please use the ClassPaths input instead.
		/// </param>
		/// <param name="RecursiveClassesExclusionSet">
		/// [DEPRECATED] - Class names are now represented by path names. If non-empty, this input will result in a runtime warning. Please use the RecursiveClassPathsExclusionSet input instead.
		/// </param>
		public static FARFilter MakeARFilter(TArray<FName> PackageNames, TArray<FName> PackagePaths, TArray<FSoftObjectPath> SoftObjectPaths, TArray<FTopLevelAssetPath> ClassPaths, TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet, TArray<FName> ClassNames, TSet<FName> RecursiveClassesExclusionSet, bool bRecursivePaths = false, bool bRecursiveClasses = false, bool bIncludeOnlyOnDiskAssets = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[59];

				*(nint*)(__InBuffer) = PackageNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PackagePaths?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SoftObjectPaths?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ClassPaths?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = RecursiveClassPathsExclusionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = ClassNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = RecursiveClassesExclusionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 56) = bRecursivePaths;

				*(bool*)(__InBuffer + 57) = bRecursiveClasses;

				*(bool*)(__InBuffer + 58) = bIncludeOnlyOnDiskAssets;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeARFilter, __InBuffer, __ReturnBuffer);

				return *(FARFilter*)__ReturnBuffer;
			}
		}

		/// <param name="InString">
		/// The string to log out
		/// </param>
		/// <param name="bPrintToLog">
		/// Whether or not to print the output to the log
		/// </param>
		public static void LogString(FString InString = null, bool bPrintToLog = true)
		{
			unsafe
			{
				InString ??= new FString("Hello");

				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InString?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bPrintToLog;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LogString, __InBuffer);
			}
		}

		/// <param name="AdIdIndex">
		/// The index of the ID to select for the ad to show
		/// </param>
		public static void LoadInterstitialAd(int AdIdIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AdIdIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LoadInterstitialAd, __InBuffer);
			}
		}

		public static UClass LoadClassAsset_Blocking(TSoftClassPtr<UObject> AssetClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadClassAsset_Blocking, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public static void LoadAssetClass(UObject WorldContextObject, TSoftClassPtr<UObject> AssetClass, FOnAssetClassLoaded OnLoaded, FLatentActionInfo LatentInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AssetClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OnLoaded?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LoadAssetClass, __InBuffer);
			}
		}

		public static UObject LoadAsset_Blocking(TSoftObjectPtr<UObject> Asset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __LoadAsset_Blocking, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public static void LoadAsset(UObject WorldContextObject, TSoftObjectPtr<UObject> Asset, FOnAssetLoaded OnLoaded, FLatentActionInfo LatentInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OnLoaded?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LoadAsset, __InBuffer);
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="ObjectTypes">
		/// Array of Object Types to trace 
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool LineTraceSingleForObjects(UObject WorldContextObject, FVector Start, FVector End, TArray<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[71];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bTraceComplex;

				*(nint*)(__InBuffer + 33) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 41) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 42) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 50) = bIgnoreSelf;

				*(nint*)(__InBuffer + 51) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 59) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 67) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __LineTraceSingleForObjects, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="ProfileName">
		/// The 'profile' used to determine which components to hit
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool LineTraceSingleByProfile(UObject WorldContextObject, FVector Start, FVector End, FName ProfileName, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[71];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bTraceComplex;

				*(nint*)(__InBuffer + 33) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 41) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 42) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 50) = bIgnoreSelf;

				*(nint*)(__InBuffer + 51) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 59) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 67) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __LineTraceSingleByProfile, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="TraceChannel">
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool LineTraceSingle(UObject WorldContextObject, FVector Start, FVector End, ETraceTypeQuery TraceChannel, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[64];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 25) = bTraceComplex;

				*(nint*)(__InBuffer + 26) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 34) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 35) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 43) = bIgnoreSelf;

				*(nint*)(__InBuffer + 44) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 52) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 60) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __LineTraceSingle, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="ObjectTypes">
		/// Array of Object Types to trace 
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool LineTraceMultiForObjects(UObject WorldContextObject, FVector Start, FVector End, TArray<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[71];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bTraceComplex;

				*(nint*)(__InBuffer + 33) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 41) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 42) = OutHits?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 50) = bIgnoreSelf;

				*(nint*)(__InBuffer + 51) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 59) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 67) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __LineTraceMultiForObjects, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHits = *(TArray<FHitResult>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="ProfileName">
		/// The 'profile' used to determine which components to hit
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a blocking hit, false otherwise.
		/// </returns>
		public static bool LineTraceMultiByProfile(UObject WorldContextObject, FVector Start, FVector End, FName ProfileName, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[71];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bTraceComplex;

				*(nint*)(__InBuffer + 33) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 41) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 42) = OutHits?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 50) = bIgnoreSelf;

				*(nint*)(__InBuffer + 51) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 59) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 67) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __LineTraceMultiByProfile, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHits = *(TArray<FHitResult>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="TraceChannel">
		/// The channel to trace
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a blocking hit, false otherwise.
		/// </returns>
		public static bool LineTraceMulti(UObject WorldContextObject, FVector Start, FVector End, ETraceTypeQuery TraceChannel, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[64];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 25) = bTraceComplex;

				*(nint*)(__InBuffer + 26) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 34) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 35) = OutHits?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 43) = bIgnoreSelf;

				*(nint*)(__InBuffer + 44) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 52) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 60) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __LineTraceMulti, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHits = *(TArray<FHitResult>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void LaunchURL(FString URL)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = URL?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LaunchURL, __InBuffer);
			}
		}

		/// <param name="Handle">
		/// The handle of the timer to unpause.
		/// </param>
		public static void K2_UnPauseTimerHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __K2_UnPauseTimerHandle, __InBuffer);
			}
		}

		/// <param name="Event">
		/// Can be a K2 function or a Custom Event.
		/// </param>
		public static void K2_UnPauseTimerDelegate(FTimerDynamicDelegate Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __K2_UnPauseTimerDelegate, __InBuffer);
			}
		}

		/// <param name="Object">
		/// Object that implements the delegate function. Defaults to self (this blueprint)
		/// </param>
		/// <param name="FunctionName">
		/// Delegate function name. Can be a K2 function or a Custom Event.
		/// </param>
		public static void K2_UnPauseTimer(UObject Object, FString FunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FunctionName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __K2_UnPauseTimer, __InBuffer);
			}
		}

		/// <param name="Handle">
		/// The handle to check whether it exists.
		/// </param>
		/// <returns>
		/// True if the timer exists.
		/// </returns>
		public static bool K2_TimerExistsHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_TimerExistsHandle, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Event">
		/// Can be a K2 function or a Custom Event.
		/// </param>
		/// <returns>
		/// True if the timer exists.
		/// </returns>
		public static bool K2_TimerExistsDelegate(FTimerDynamicDelegate Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_TimerExistsDelegate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// Object that implements the delegate function. Defaults to self (this blueprint)
		/// </param>
		/// <param name="FunctionName">
		/// Delegate function name. Can be a K2 function or a Custom Event.
		/// </param>
		/// <returns>
		/// True if the timer exists.
		/// </returns>
		public static bool K2_TimerExists(UObject Object, FString FunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FunctionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_TimerExists, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Event">
		/// Event. Can be a K2 function or a Custom Event.
		/// </param>
		/// <returns>
		/// The timer handle to pass to other timer functions to manipulate this timer.
		/// </returns>
		public static FTimerHandle K2_SetTimerForNextTickDelegate(FTimerDynamicDelegate Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_SetTimerForNextTickDelegate, __InBuffer, __ReturnBuffer);

				return *(FTimerHandle*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// Object that implements the delegate function. Defaults to self (this blueprint)
		/// </param>
		/// <param name="FunctionName">
		/// Delegate function name. Can be a K2 function or a Custom Event.
		/// </param>
		/// <returns>
		/// The timer handle to pass to other timer functions to manipulate this timer.
		/// </returns>
		public static FTimerHandle K2_SetTimerForNextTick(UObject Object, FString FunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FunctionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_SetTimerForNextTick, __InBuffer, __ReturnBuffer);

				return *(FTimerHandle*)__ReturnBuffer;
			}
		}

		/// <param name="Event">
		/// Event. Can be a K2 function or a Custom Event.
		/// </param>
		/// <param name="Time">
		/// How long to wait before executing the delegate, in seconds. Setting a timer to <= 0 seconds will clear it if it is set.
		/// </param>
		/// <param name="bLooping">
		/// True to keep executing the delegate every Time seconds, false to execute delegate only once.
		/// </param>
		/// <param name="InitialStartDelay">
		/// Initial delay passed to the timer manager, in seconds.
		/// </param>
		/// <param name="InitialStartDelayVariance">
		/// Use this to add some variance to when the timer starts in lieu of doing a random range on the InitialStartDelay input, in seconds. 
		/// </param>
		/// <returns>
		/// The timer handle to pass to other timer functions to manipulate this timer.
		/// </returns>
		public static FTimerHandle K2_SetTimerDelegate(FTimerDynamicDelegate Delegate, float Time, bool bLooping, float InitialStartDelay = 0.000000f, float InitialStartDelayVariance = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Time;

				*(bool*)(__InBuffer + 12) = bLooping;

				*(float*)(__InBuffer + 13) = InitialStartDelay;

				*(float*)(__InBuffer + 17) = InitialStartDelayVariance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_SetTimerDelegate, __InBuffer, __ReturnBuffer);

				return *(FTimerHandle*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// Object that implements the delegate function. Defaults to self (this blueprint)
		/// </param>
		/// <param name="FunctionName">
		/// Delegate function name. Can be a K2 function or a Custom Event.
		/// </param>
		/// <param name="Time">
		/// How long to wait before executing the delegate, in seconds. Setting a timer to <= 0 seconds will clear it if it is set.
		/// </param>
		/// <param name="bLooping">
		/// true to keep executing the delegate every Time seconds, false to execute delegate only once.
		/// </param>
		/// <param name="InitialStartDelay">
		/// Initial delay passed to the timer manager to allow some variance in when the timer starts, in seconds.
		/// </param>
		/// <param name="InitialStartDelayVariance">
		/// Use this to add some variance to when the timer starts in lieu of doing a random range on the InitialStartDelay input, in seconds.
		/// </param>
		/// <returns>
		/// The timer handle to pass to other timer functions to manipulate this timer.
		/// </returns>
		public static FTimerHandle K2_SetTimer(UObject Object, FString FunctionName, float Time, bool bLooping, float InitialStartDelay = 0.000000f, float InitialStartDelayVariance = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FunctionName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Time;

				*(bool*)(__InBuffer + 20) = bLooping;

				*(float*)(__InBuffer + 21) = InitialStartDelay;

				*(float*)(__InBuffer + 25) = InitialStartDelayVariance;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_SetTimer, __InBuffer, __ReturnBuffer);

				return *(FTimerHandle*)__ReturnBuffer;
			}
		}

		/// <param name="Handle">
		/// The handle of the timer to pause.
		/// </param>
		public static void K2_PauseTimerHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __K2_PauseTimerHandle, __InBuffer);
			}
		}

		/// <param name="Event">
		/// Can be a K2 function or a Custom Event.
		/// </param>
		public static void K2_PauseTimerDelegate(FTimerDynamicDelegate Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __K2_PauseTimerDelegate, __InBuffer);
			}
		}

		/// <param name="Object">
		/// Object that implements the delegate function. Defaults to self (this blueprint)
		/// </param>
		/// <param name="FunctionName">
		/// Delegate function name. Can be a K2 function or a Custom Event.
		/// </param>
		public static void K2_PauseTimer(UObject Object, FString FunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FunctionName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __K2_PauseTimer, __InBuffer);
			}
		}

		/// <param name="Handle">
		/// The handle of the timer to check validity of.
		/// </param>
		/// <returns>
		/// Whether the timer handle is valid.
		/// </returns>
		public static bool K2_IsValidTimerHandle(FTimerHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_IsValidTimerHandle, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Handle">
		/// The handle of the timer to check whether it is paused.
		/// </param>
		/// <returns>
		/// True if the timer exists and is paused.
		/// </returns>
		public static bool K2_IsTimerPausedHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_IsTimerPausedHandle, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Event">
		/// Can be a K2 function or a Custom Event.
		/// </param>
		/// <returns>
		/// True if the timer exists and is paused.
		/// </returns>
		public static bool K2_IsTimerPausedDelegate(FTimerDynamicDelegate Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_IsTimerPausedDelegate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// Object that implements the delegate function. Defaults to self (this blueprint)
		/// </param>
		/// <param name="FunctionName">
		/// Delegate function name. Can be a K2 function or a Custom Event.
		/// </param>
		/// <returns>
		/// True if the timer exists and is paused.
		/// </returns>
		public static bool K2_IsTimerPaused(UObject Object, FString FunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FunctionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_IsTimerPaused, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Handle">
		/// The handle of the timer to check whether it is active.
		/// </param>
		/// <returns>
		/// True if the timer exists and is active.
		/// </returns>
		public static bool K2_IsTimerActiveHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_IsTimerActiveHandle, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Event">
		/// Can be a K2 function or a Custom Event.
		/// </param>
		/// <returns>
		/// True if the timer exists and is active.
		/// </returns>
		public static bool K2_IsTimerActiveDelegate(FTimerDynamicDelegate Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_IsTimerActiveDelegate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// Object that implements the delegate function. Defaults to self (this blueprint)
		/// </param>
		/// <param name="FunctionName">
		/// Delegate function name. Can be a K2 function or a Custom Event.
		/// </param>
		/// <returns>
		/// True if the timer exists and is active.
		/// </returns>
		public static bool K2_IsTimerActive(UObject Object, FString FunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FunctionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_IsTimerActive, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Handle">
		/// The handle of the timer to invalidate.
		/// </param>
		/// <returns>
		/// Return the invalidated timer handle for convenience.
		/// </returns>
		public static FTimerHandle K2_InvalidateTimerHandle(ref FTimerHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __K2_InvalidateTimerHandle, __InBuffer, __OutBuffer, __ReturnBuffer);

				Handle = *(FTimerHandle*)(__OutBuffer);

				return *(FTimerHandle*)__ReturnBuffer;
			}
		}

		/// <param name="Handle">
		/// The handle of the timer to time remaining of.
		/// </param>
		/// <returns>
		/// How long is remaining in the current iteration of the timer.
		/// </returns>
		public static float K2_GetTimerRemainingTimeHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_GetTimerRemainingTimeHandle, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Event">
		/// Can be a K2 function or a Custom Event.
		/// </param>
		/// <returns>
		/// How long is remaining in the current iteration of the timer.
		/// </returns>
		public static float K2_GetTimerRemainingTimeDelegate(FTimerDynamicDelegate Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_GetTimerRemainingTimeDelegate, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// Object that implements the delegate function. Defaults to self (this blueprint)
		/// </param>
		/// <param name="FunctionName">
		/// Delegate function name. Can be a K2 function or a Custom Event.
		/// </param>
		/// <returns>
		/// How long is remaining in the current iteration of the timer.
		/// </returns>
		public static float K2_GetTimerRemainingTime(UObject Object, FString FunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FunctionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_GetTimerRemainingTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Handle">
		/// The handle of the timer to get the elapsed time of.
		/// </param>
		/// <returns>
		/// How long has elapsed since the current iteration of the timer began.
		/// </returns>
		public static float K2_GetTimerElapsedTimeHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_GetTimerElapsedTimeHandle, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Event">
		/// Can be a K2 function or a Custom Event.
		/// </param>
		/// <returns>
		/// How long has elapsed since the current iteration of the timer began.
		/// </returns>
		public static float K2_GetTimerElapsedTimeDelegate(FTimerDynamicDelegate Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_GetTimerElapsedTimeDelegate, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// Object that implements the delegate function. Defaults to self (this blueprint)
		/// </param>
		/// <param name="FunctionName">
		/// Delegate function name. Can be a K2 function or a Custom Event.
		/// </param>
		/// <returns>
		/// How long has elapsed since the current iteration of the timer began.
		/// </returns>
		public static float K2_GetTimerElapsedTime(UObject Object, FString FunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FunctionName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_GetTimerElapsedTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Handle">
		/// The handle of the timer to clear.
		/// </param>
		public static void K2_ClearTimerHandle(UObject WorldContextObject, FTimerHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __K2_ClearTimerHandle, __InBuffer);
			}
		}

		/// <param name="Event">
		/// Can be a K2 function or a Custom Event.
		/// </param>
		public static void K2_ClearTimerDelegate(FTimerDynamicDelegate Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __K2_ClearTimerDelegate, __InBuffer);
			}
		}

		/// <param name="Object">
		/// Object that implements the delegate function. Defaults to self (this blueprint)
		/// </param>
		/// <param name="FunctionName">
		/// Delegate function name. Can be a K2 function or a Custom Event.
		/// </param>
		public static void K2_ClearTimer(UObject Object, FString FunctionName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FunctionName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __K2_ClearTimer, __InBuffer);
			}
		}

		/// <param name="Handle">
		/// The handle of the timer to clear.
		/// </param>
		public static void K2_ClearAndInvalidateTimerHandle(UObject WorldContextObject, ref FTimerHandle Handle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __K2_ClearAndInvalidateTimerHandle, __InBuffer, __OutBuffer);

				Handle = *(FTimerHandle*)(__OutBuffer);

			}
		}

		public static bool IsValidSoftObjectReference(TSoftObjectPtr<UObject> SoftObjectReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftObjectReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidSoftObjectReference, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsValidSoftClassReference(TSoftClassPtr<UObject> SoftClassReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftClassReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidSoftClassReference, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsValidPrimaryAssetType(FPrimaryAssetType PrimaryAssetType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrimaryAssetType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidPrimaryAssetType, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsValidPrimaryAssetId(FPrimaryAssetId PrimaryAssetId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrimaryAssetId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidPrimaryAssetId, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsValidClass(UClass Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidClass, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsValid(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Unattended state
		/// </returns>
		public static bool IsUnattended()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsUnattended, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsStandalone(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsStandalone, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsSplitScreen(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsSplitScreen, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsServer(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsServer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsScreensaverEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsScreensaverEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsPackagedForDistribution()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsPackagedForDistribution, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Player">
		/// Specific player's login status to get. May not be supported on all platforms. If null, defaults to the player with ControllerId 0.
		/// </param>
		public static bool IsLoggedIn(APlayerController SpecificPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SpecificPlayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsLoggedIn, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsInterstitialAdRequested()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsInterstitialAdRequested, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsInterstitialAdAvailable()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsInterstitialAdAvailable, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsDedicatedServer(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsDedicatedServer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsControllerAssignedToGamepad(int ControllerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ControllerId;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsControllerAssignedToGamepad, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void HideAdBanner()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __HideAdBanner);
			}
		}

		public static bool HasMultipleLocalPlayers(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasMultipleLocalPlayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetVolumeButtonsHandledBySystem()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetVolumeButtonsHandledBySystem, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString GetUniqueDeviceId()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetUniqueDeviceId, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetSystemPath(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSystemPath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if successfully queried the device for available resolutions.
		/// </returns>
		public static bool GetSupportedFullscreenResolutions(ref TArray<FIntPoint> Resolutions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Resolutions?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetSupportedFullscreenResolutions, __InBuffer, __OutBuffer, __ReturnBuffer);

				Resolutions = *(TArray<FIntPoint>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FTopLevelAssetPath GetStructTopLevelAssetPath(UScriptStruct Struct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Struct?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStructTopLevelAssetPath, __InBuffer, __ReturnBuffer);

				return *(FTopLevelAssetPath*)__ReturnBuffer;
			}
		}

		public static TSoftObjectPtr<UObject> GetSoftObjectReferenceFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrimaryAssetId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSoftObjectReferenceFromPrimaryAssetId, __InBuffer, __ReturnBuffer);

				return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
			}
		}

		public static FSoftObjectPath GetSoftObjectPath(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSoftObjectPath, __InBuffer, __ReturnBuffer);

				return *(FSoftObjectPath*)__ReturnBuffer;
			}
		}

		public static FTopLevelAssetPath GetSoftClassTopLevelAssetPath(TSoftClassPtr<UObject> SoftClassReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftClassReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSoftClassTopLevelAssetPath, __InBuffer, __ReturnBuffer);

				return *(FTopLevelAssetPath*)__ReturnBuffer;
			}
		}

		public static TSoftClassPtr<UObject> GetSoftClassReferenceFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrimaryAssetId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSoftClassReferenceFromPrimaryAssetId, __InBuffer, __ReturnBuffer);

				return *(TSoftClassPtr<UObject>*)__ReturnBuffer;
			}
		}

		public static FSoftClassPath GetSoftClassPath(UClass Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSoftClassPath, __InBuffer, __ReturnBuffer);

				return *(FSoftClassPath*)__ReturnBuffer;
			}
		}

		public static int GetRenderingMaterialQualityLevel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetRenderingMaterialQualityLevel, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int GetRenderingDetailMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetRenderingDetailMode, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FString GetProjectSavedDirectory()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetProjectSavedDirectory, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetProjectDirectory()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetProjectDirectory, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetProjectContentDirectory()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetProjectContentDirectory, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static void GetPrimaryAssetsWithBundleState(TArray<FName> RequiredBundles, TArray<FName> ExcludedBundles, TArray<FPrimaryAssetType> ValidTypes, bool bForceCurrentState, ref TArray<FPrimaryAssetId> OutPrimaryAssetIdList)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = RequiredBundles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExcludedBundles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ValidTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bForceCurrentState;

				*(nint*)(__InBuffer + 25) = OutPrimaryAssetIdList?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetPrimaryAssetsWithBundleState, __InBuffer, __OutBuffer);

				OutPrimaryAssetIdList = *(TArray<FPrimaryAssetId>*)(__OutBuffer);

			}
		}

		public static void GetPrimaryAssetIdList(FPrimaryAssetType PrimaryAssetType, ref TArray<FPrimaryAssetId> OutPrimaryAssetIdList)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = PrimaryAssetType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPrimaryAssetIdList?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetPrimaryAssetIdList, __InBuffer, __OutBuffer);

				OutPrimaryAssetIdList = *(TArray<FPrimaryAssetId>*)(__OutBuffer);

			}
		}

		public static FPrimaryAssetId GetPrimaryAssetIdFromSoftObjectReference(TSoftObjectPtr<UObject> SoftObjectReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftObjectReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPrimaryAssetIdFromSoftObjectReference, __InBuffer, __ReturnBuffer);

				return *(FPrimaryAssetId*)__ReturnBuffer;
			}
		}

		public static FPrimaryAssetId GetPrimaryAssetIdFromSoftClassReference(TSoftClassPtr<UObject> SoftClassReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftClassReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPrimaryAssetIdFromSoftClassReference, __InBuffer, __ReturnBuffer);

				return *(FPrimaryAssetId*)__ReturnBuffer;
			}
		}

		public static FPrimaryAssetId GetPrimaryAssetIdFromObject(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPrimaryAssetIdFromObject, __InBuffer, __ReturnBuffer);

				return *(FPrimaryAssetId*)__ReturnBuffer;
			}
		}

		public static FPrimaryAssetId GetPrimaryAssetIdFromClass(TSubclassOf<UObject> Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPrimaryAssetIdFromClass, __InBuffer, __ReturnBuffer);

				return *(FPrimaryAssetId*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// An array of language IDs ordered from most preferred to least
		/// </returns>
		public static TArray<FString> GetPreferredLanguages()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetPreferredLanguages, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		public static FString GetPlatformUserName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetPlatformUserName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetPlatformUserDir()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetPlatformUserDir, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static double GetPlatformTime_Seconds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetPlatformTime_Seconds, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FString GetPathName(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPathName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static UObject GetOuterObject(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetOuterObject, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public static FString GetObjectName(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetObjectName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static UObject GetObjectFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrimaryAssetId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetObjectFromPrimaryAssetId, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// value in pixels
		/// </returns>
		public static int GetMinYResolutionForUI()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetMinYResolutionForUI, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// value in pixels
		/// </returns>
		public static int GetMinYResolutionFor3DView()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetMinYResolutionFor3DView, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the currency symbol associated with the device's locale
		/// </returns>
		public static FString GetLocalCurrencySymbol()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetLocalCurrencySymbol, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the currency code associated with the device's locale
		/// </returns>
		public static FString GetLocalCurrencyCode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetLocalCurrencyCode, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContextObject">
		/// World context
		/// </param>
		public static double GetGameTimeInSeconds(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetGameTimeInSeconds, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static FString GetGamepadControllerName(int ControllerId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = ControllerId;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetGamepadControllerName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static UTexture2D GetGamepadButtonGlyph(FString ButtonKey, int ControllerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ButtonKey?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ControllerIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetGamepadButtonGlyph, __InBuffer, __ReturnBuffer);

				return *(UTexture2D*)__ReturnBuffer;
			}
		}

		public static FString GetGameName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetGameName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The game's bundle identifier or package name.
		/// </returns>
		public static FString GetGameBundleId()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetGameBundleId, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static long GetFrameCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetFrameCount, __ReturnBuffer);

				return *(long*)__ReturnBuffer;
			}
		}

		public static FTopLevelAssetPath GetEnumTopLevelAssetPath(UEnum Enum)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Enum?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetEnumTopLevelAssetPath, __InBuffer, __ReturnBuffer);

				return *(FTopLevelAssetPath*)__ReturnBuffer;
			}
		}

		public static FString GetEngineVersion()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetEngineVersion, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="Object">
		/// The object you want to retrieve a property value from.
		/// </param>
		/// <param name="PropertyName">
		/// The name of the object property to retrieve the value from.
		/// </param>
		/// <param name="PropertyValue">
		/// The retrieved property value, if found.
		/// </param>
		/// <returns>
		/// Whether the property value was found and correctly retrieved.
		/// </returns>
		public static bool GetEditorProperty(UObject Object, FName PropertyName, ref int PropertyValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PropertyName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = PropertyValue;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetEditorProperty, __InBuffer, __OutBuffer, __ReturnBuffer);

				PropertyValue = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static FString GetDisplayName(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDisplayName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetDeviceId()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetDeviceId, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <note>
		/// This should be returned in IETF language tag form:
		/// - A two-letter ISO 639-1 language code (eg, "zh")
		/// - An optional four-letter ISO 15924 script code (eg, "Hans")
		/// - An optional two-letter ISO 3166-1 country code (eg, "CN")
		/// </note>
		/// <returns>
		/// The locale as an IETF language tag (eg, "zh-Hans-CN")
		/// </returns>
		public static FString GetDefaultLocale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetDefaultLocale, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <note>
		/// This is typically the same as GetDefaultLocale unless the platform distinguishes between the two
		/// </note>
		/// <note>
		/// This should be returned in IETF language tag form:
		/// - A two-letter ISO 639-1 language code (eg, "zh")
		/// - An optional four-letter ISO 15924 script code (eg, "Hans")
		/// - An optional two-letter ISO 3166-1 country code (eg, "CN")
		/// </note>
		/// <returns>
		/// The language as an IETF language tag (eg, "zh-Hans-CN")
		/// </returns>
		public static FString GetDefaultLanguage()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetDefaultLanguage, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static bool GetCurrentBundleState(FPrimaryAssetId PrimaryAssetId, bool bForceCurrentState, ref TArray<FName> OutBundles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = PrimaryAssetId?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForceCurrentState;

				*(nint*)(__InBuffer + 9) = OutBundles?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentBundleState, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutBundles = *(TArray<FName>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if successfully queried the device for available resolutions.
		/// </returns>
		public static bool GetConvenientWindowedResolutions(ref TArray<FIntPoint> Resolutions)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Resolutions?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetConvenientWindowedResolutions, __InBuffer, __OutBuffer, __ReturnBuffer);

				Resolutions = *(TArray<FIntPoint>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="VariableName">
		/// Name of the console variable to find.
		/// </param>
		/// <returns>
		/// The value if found, empty string otherwise.
		/// </returns>
		public static FString GetConsoleVariableStringValue(FString VariableName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VariableName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetConsoleVariableStringValue, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		/// <param name="VariableName">
		/// Name of the console variable to find.
		/// </param>
		/// <returns>
		/// The value if found, 0 otherwise.
		/// </returns>
		public static int GetConsoleVariableIntValue(FString VariableName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VariableName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetConsoleVariableIntValue, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="VariableName">
		/// Name of the console variable to find.
		/// </param>
		/// <returns>
		/// The value if found, 0 otherwise.
		/// </returns>
		public static float GetConsoleVariableFloatValue(FString VariableName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VariableName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetConsoleVariableFloatValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="VariableName">
		/// Name of the console variable to find.
		/// </param>
		/// <returns>
		/// True if found and has a non-zero value, false otherwise.
		/// </returns>
		public static bool GetConsoleVariableBoolValue(FString VariableName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = VariableName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetConsoleVariableBoolValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void GetComponentBounds(USceneComponent Component, ref FVector Origin, ref FVector BoxExtent, ref float SphereRadius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = SphereRadius;

				var __OutBuffer = stackalloc byte[20];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetComponentBounds, __InBuffer, __OutBuffer);

				Origin = *(FVector*)(__OutBuffer);

				BoxExtent = *(FVector*)(__OutBuffer + 8);

				SphereRadius = *(float*)(__OutBuffer + 16);

			}
		}

		public static FString GetCommandLine()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetCommandLine, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FTopLevelAssetPath GetClassTopLevelAssetPath(UClass Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetClassTopLevelAssetPath, __InBuffer, __ReturnBuffer);

				return *(FTopLevelAssetPath*)__ReturnBuffer;
			}
		}

		public static TSubclassOf<UObject> GetClassFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrimaryAssetId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetClassFromPrimaryAssetId, __InBuffer, __ReturnBuffer);

				return *(TSubclassOf<UObject>*)__ReturnBuffer;
			}
		}

		public static FString GetClassDisplayName(UClass Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetClassDisplayName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetBuildVersion()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetBuildVersion, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString GetBuildConfiguration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetBuildConfiguration, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static int GetAdIDCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAdIDCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="ComponentList">
		/// List of components.
		/// </param>
		/// <param name="ClassFilter">
		/// If set, will only return results of this class or subclasses of it.
		/// </param>
		/// <param name="OutActorList">
		/// Start of line segment.
		/// </param>
		public static void GetActorListFromComponentList(TArray<UPrimitiveComponent> ComponentList, UClass ActorClassFilter, ref TArray<AActor> OutActorList)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ComponentList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ActorClassFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutActorList?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetActorListFromComponentList, __InBuffer, __OutBuffer);

				OutActorList = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		public static void GetActorBounds(AActor Actor, ref FVector Origin, ref FVector BoxExtent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetActorBounds, __InBuffer, __OutBuffer);

				Origin = *(FVector*)(__OutBuffer);

				BoxExtent = *(FVector*)(__OutBuffer + 8);

			}
		}

		public static void ForceCloseAdBanner()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __ForceCloseAdBanner);
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		public static void FlushPersistentDebugLines(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __FlushPersistentDebugLines, __InBuffer);
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		public static void FlushDebugStrings(UObject WorldContextObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __FlushDebugStrings, __InBuffer);
			}
		}

		/// <param name="Command">
		/// Command to send to the console
		/// </param>
		/// <param name="SpecificPlayer">
		/// If specified, the console command will be routed through the specified player
		/// </param>
		public static void ExecuteConsoleCommand(UObject WorldContextObject, FString Command, APlayerController SpecificPlayer = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Command?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SpecificPlayer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ExecuteConsoleCommand, __InBuffer);
			}
		}

		public static bool EqualEqual_SoftObjectReference(TSoftObjectPtr<UObject> A, TSoftObjectPtr<UObject> B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_SoftObjectReference, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_SoftClassReference(TSoftClassPtr<UObject> A, TSoftClassPtr<UObject> B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_SoftClassReference, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_PrimaryAssetType(FPrimaryAssetType A, FPrimaryAssetType B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_PrimaryAssetType, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool EqualEqual_PrimaryAssetId(FPrimaryAssetId A, FPrimaryAssetId B)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = A?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = B?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EqualEqual_PrimaryAssetId, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Only available in the editor.
		/// </note>
		/// <returns>
		/// The number of active actions when EndTransaction was called (a value of 1 indicates that the transaction was successfully closed), or -1 on failure.
		/// </returns>
		public static int EndTransaction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __EndTransaction, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void DrawDebugString(UObject WorldContextObject, FVector TextLocation, FString Text, AActor TestBaseActor = null, FLinearColor TextColor = null, float Duration = 0.000000f)
		{
			unsafe
			{
				TextColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[44];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TextLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Text?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = TestBaseActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = TextColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = Duration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugString, __InBuffer);
			}
		}

		public static void DrawDebugSphere(UObject WorldContextObject, FVector Center, float Radius = 100.000000f, int Segments = 12, FLinearColor LineColor = null, float Duration = 0.000000f, float Thickness = 0.000000f)
		{
			unsafe
			{
				LineColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Center?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Radius;

				*(int*)(__InBuffer + 20) = Segments;

				*(nint*)(__InBuffer + 24) = LineColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = Duration;

				*(float*)(__InBuffer + 36) = Thickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugSphere, __InBuffer);
			}
		}

		public static void DrawDebugPoint(UObject WorldContextObject, FVector Position, float Size, FLinearColor PointColor, float Duration = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Size;

				*(nint*)(__InBuffer + 20) = PointColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 28) = Duration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugPoint, __InBuffer);
			}
		}

		public static void DrawDebugPlane(UObject WorldContextObject, FPlane PlaneCoordinates, FVector Location, float Size, FLinearColor PlaneColor = null, float Duration = 0.000000f)
		{
			unsafe
			{
				PlaneColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PlaneCoordinates?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Size;

				*(nint*)(__InBuffer + 28) = PlaneColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 36) = Duration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugPlane, __InBuffer);
			}
		}

		public static void DrawDebugLine(UObject WorldContextObject, FVector LineStart, FVector LineEnd, FLinearColor LineColor, float Duration = 0.000000f, float Thickness = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LineStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LineEnd?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = LineColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = Duration;

				*(float*)(__InBuffer + 36) = Thickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugLine, __InBuffer);
			}
		}

		public static void DrawDebugFrustum(UObject WorldContextObject, FTransform FrustumTransform, FLinearColor FrustumColor = null, float Duration = 0.000000f, float Thickness = 0.000000f)
		{
			unsafe
			{
				FrustumColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FrustumTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = FrustumColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Duration;

				*(float*)(__InBuffer + 28) = Thickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugFrustum, __InBuffer);
			}
		}

		public static void DrawDebugFloatHistoryTransform(UObject WorldContextObject, FDebugFloatHistory FloatHistory, FTransform DrawTransform, FVector2D DrawSize, FLinearColor DrawColor = null, float Duration = 0.000000f)
		{
			unsafe
			{
				DrawColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[44];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FloatHistory?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DrawTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = DrawSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = DrawColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = Duration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugFloatHistoryTransform, __InBuffer);
			}
		}

		public static void DrawDebugFloatHistoryLocation(UObject WorldContextObject, FDebugFloatHistory FloatHistory, FVector DrawLocation, FVector2D DrawSize, FLinearColor DrawColor = null, float Duration = 0.000000f)
		{
			unsafe
			{
				DrawColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[44];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FloatHistory?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DrawLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = DrawSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = DrawColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = Duration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugFloatHistoryLocation, __InBuffer);
			}
		}

		public static void DrawDebugCylinder(UObject WorldContextObject, FVector Start, FVector End, float Radius = 100.000000f, int Segments = 12, FLinearColor LineColor = null, float Duration = 0.000000f, float Thickness = 0.000000f)
		{
			unsafe
			{
				LineColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(int*)(__InBuffer + 28) = Segments;

				*(nint*)(__InBuffer + 32) = LineColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = Duration;

				*(float*)(__InBuffer + 44) = Thickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugCylinder, __InBuffer);
			}
		}

		public static void DrawDebugCoordinateSystem(UObject WorldContextObject, FVector AxisLoc, FRotator AxisRot, float Scale = 1.000000f, float Duration = 0.000000f, float Thickness = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AxisLoc?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AxisRot?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Scale;

				*(float*)(__InBuffer + 28) = Duration;

				*(float*)(__InBuffer + 32) = Thickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugCoordinateSystem, __InBuffer);
			}
		}

		public static void DrawDebugConeInDegrees(UObject WorldContextObject, FVector Origin, FVector Direction, float Length = 100.000000f, float AngleWidth = 45.000000f, float AngleHeight = 45.000000f, int NumSides = 12, FLinearColor LineColor = null, float Duration = 0.000000f, float Thickness = 0.000000f)
		{
			unsafe
			{
				LineColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[56];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Direction?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Length;

				*(float*)(__InBuffer + 28) = AngleWidth;

				*(float*)(__InBuffer + 32) = AngleHeight;

				*(int*)(__InBuffer + 36) = NumSides;

				*(nint*)(__InBuffer + 40) = LineColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 48) = Duration;

				*(float*)(__InBuffer + 52) = Thickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugConeInDegrees, __InBuffer);
			}
		}

		public static void DrawDebugCone(UObject WorldContextObject, FVector Origin, FVector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration = 0.000000f, float Thickness = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[56];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Direction?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Length;

				*(float*)(__InBuffer + 28) = AngleWidth;

				*(float*)(__InBuffer + 32) = AngleHeight;

				*(int*)(__InBuffer + 36) = NumSides;

				*(nint*)(__InBuffer + 40) = LineColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 48) = Duration;

				*(float*)(__InBuffer + 52) = Thickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugCone, __InBuffer);
			}
		}

		public static void DrawDebugCircle(UObject WorldContextObject, FVector Center, float Radius, int NumSegments = 12, FLinearColor LineColor = null, float Duration = 0.000000f, float Thickness = 0.000000f, FVector YAxis = null, FVector ZAxis = null, bool bDrawAxis = false)
		{
			unsafe
			{
				LineColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				YAxis ??= new FVector(0.000000, 1.000000, 0.000000);

				ZAxis ??= new FVector(0.000000, 0.000000, 1.000000);

				var __InBuffer = stackalloc byte[57];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Center?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Radius;

				*(int*)(__InBuffer + 20) = NumSegments;

				*(nint*)(__InBuffer + 24) = LineColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = Duration;

				*(float*)(__InBuffer + 36) = Thickness;

				*(nint*)(__InBuffer + 40) = YAxis?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = ZAxis?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 56) = bDrawAxis;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugCircle, __InBuffer);
			}
		}

		public static void DrawDebugCapsule(UObject WorldContextObject, FVector Center, float HalfHeight, float Radius, FRotator Rotation, FLinearColor LineColor = null, float Duration = 0.000000f, float Thickness = 0.000000f)
		{
			unsafe
			{
				LineColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Center?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = HalfHeight;

				*(float*)(__InBuffer + 20) = Radius;

				*(nint*)(__InBuffer + 24) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = LineColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = Duration;

				*(float*)(__InBuffer + 44) = Thickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugCapsule, __InBuffer);
			}
		}

		public static void DrawDebugCamera(ACameraActor CameraActor, FLinearColor CameraColor = null, float Duration = 0.000000f)
		{
			unsafe
			{
				CameraColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = CameraActor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CameraColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Duration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugCamera, __InBuffer);
			}
		}

		public static void DrawDebugBox(UObject WorldContextObject, FVector Center, FVector Extent, FLinearColor LineColor, FRotator Rotation = null, float Duration = 0.000000f, float Thickness = 0.000000f)
		{
			unsafe
			{
				Rotation ??= new FRotator();

				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Center?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Extent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = LineColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 40) = Duration;

				*(float*)(__InBuffer + 44) = Thickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugBox, __InBuffer);
			}
		}

		public static void DrawDebugArrow(UObject WorldContextObject, FVector LineStart, FVector LineEnd, float ArrowSize, FLinearColor LineColor, float Duration = 0.000000f, float Thickness = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[44];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LineStart?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LineEnd?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = ArrowSize;

				*(nint*)(__InBuffer + 28) = LineColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 36) = Duration;

				*(float*)(__InBuffer + 40) = Thickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DrawDebugArrow, __InBuffer);
			}
		}

		public static bool DoesImplementInterface(UObject TestObject, TSubclassOf<UInterface> Interface)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TestObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Interface?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DoesImplementInterface, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context.
		/// </param>
		/// <param name="LatentInfo">
		/// The latent action.
		/// </param>
		public static void DelayUntilNextTick(UObject WorldContextObject, FLatentActionInfo LatentInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DelayUntilNextTick, __InBuffer);
			}
		}

		/// <param name="WorldContext">
		/// World context.
		/// </param>
		/// <param name="Duration">
		/// length of delay (in seconds).
		/// </param>
		/// <param name="LatentInfo">
		/// The latent action.
		/// </param>
		public static void Delay(UObject WorldContextObject, float Duration, FLatentActionInfo LatentInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Duration;

				*(nint*)(__InBuffer + 12) = LatentInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Delay, __InBuffer);
			}
		}

		public static void CreateCopyForUndoBuffer(UObject ObjectToModify)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ObjectToModify?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __CreateCopyForUndoBuffer, __InBuffer);
			}
		}

		public static FString ConvertToRelativePath(FString Filename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Filename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertToRelativePath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString ConvertToAbsolutePath(FString Filename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Filename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __ConvertToAbsolutePath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FSoftObjectPath Conv_SoftObjRefToSoftObjPath(TSoftObjectPtr<UObject> SoftObjectReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftObjectReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_SoftObjRefToSoftObjPath, __InBuffer, __ReturnBuffer);

				return *(FSoftObjectPath*)__ReturnBuffer;
			}
		}

		public static FSoftClassPath Conv_SoftObjRefToSoftClassPath(TSoftClassPtr<UObject> SoftClassReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftClassReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_SoftObjRefToSoftClassPath, __InBuffer, __ReturnBuffer);

				return *(FSoftClassPath*)__ReturnBuffer;
			}
		}

		public static TSoftObjectPtr<UObject> Conv_SoftObjPathToSoftObjRef(FSoftObjectPath SoftObjectPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_SoftObjPathToSoftObjRef, __InBuffer, __ReturnBuffer);

				return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
			}
		}

		public static FString Conv_SoftObjectReferenceToString(TSoftObjectPtr<UObject> SoftObjectReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftObjectReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_SoftObjectReferenceToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static UObject Conv_SoftObjectReferenceToObject(TSoftObjectPtr<UObject> SoftObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_SoftObjectReferenceToObject, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public static FString Conv_SoftClassReferenceToString(TSoftClassPtr<UObject> SoftClassReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftClassReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_SoftClassReferenceToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static TSubclassOf<UObject> Conv_SoftClassReferenceToClass(TSoftClassPtr<UObject> SoftClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_SoftClassReferenceToClass, __InBuffer, __ReturnBuffer);

				return *(TSubclassOf<UObject>*)__ReturnBuffer;
			}
		}

		public static TSoftClassPtr<UObject> Conv_SoftClassPathToSoftClassRef(FSoftClassPath SoftClassPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SoftClassPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_SoftClassPathToSoftClassRef, __InBuffer, __ReturnBuffer);

				return *(TSoftClassPtr<UObject>*)__ReturnBuffer;
			}
		}

		public static FString Conv_PrimaryAssetTypeToString(FPrimaryAssetType PrimaryAssetType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrimaryAssetType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_PrimaryAssetTypeToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString Conv_PrimaryAssetIdToString(FPrimaryAssetId PrimaryAssetId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PrimaryAssetId?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_PrimaryAssetIdToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static TSoftObjectPtr<UObject> Conv_ObjectToSoftObjectReference(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ObjectToSoftObjectReference, __InBuffer, __ReturnBuffer);

				return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
			}
		}

		public static UClass Conv_ObjectToClass(UObject Object, TSubclassOf<UObject> Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ObjectToClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public static UObject Conv_InterfaceToObject(TScriptInterface<IInterface> Interface)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Interface?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_InterfaceToObject, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public static FSoftComponentReference Conv_ComponentReferenceToSoftComponentReference(FComponentReference ComponentReference)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ComponentReference?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ComponentReferenceToSoftComponentReference, __InBuffer, __ReturnBuffer);

				return *(FSoftComponentReference*)__ReturnBuffer;
			}
		}

		public static TSoftClassPtr<UObject> Conv_ClassToSoftClassReference(TSubclassOf<UObject> Class)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Class?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_ClassToSoftClassReference, __InBuffer, __ReturnBuffer);

				return *(TSoftClassPtr<UObject>*)__ReturnBuffer;
			}
		}

		/// <param name="bAllowScreenSaver">
		/// If false, don't allow screensaver if possible, otherwise allow default behavior
		/// </param>
		public static void ControlScreensaver(bool bAllowScreenSaver)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bAllowScreenSaver;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ControlScreensaver, __InBuffer);
			}
		}

		/// <param name="Component">
		/// Component to test with.
		/// </param>
		/// <param name="ComponentTransform">
		/// Defines where to place the component for overlap testing.
		/// </param>
		/// <param name="Filter">
		/// Option to restrict results to only static or only dynamic.  For efficiency.
		/// </param>
		/// <param name="ClassFilter">
		/// If set, will only return results of this class or subclasses of it.
		/// </param>
		/// <param name="ActorsToIgnore">
		/// Ignore these actors in the list
		/// </param>
		/// <param name="OutActors">
		/// Returned array of actors. Unsorted.
		/// </param>
		/// <returns>
		/// true if there was an overlap that passed the filters, false otherwise.
		/// </returns>
		public static bool ComponentOverlapComponents(UPrimitiveComponent Component, FTransform ComponentTransform, TArray<EObjectTypeQuery> ObjectTypes, UClass ComponentClassFilter, TArray<AActor> ActorsToIgnore, ref TArray<UPrimitiveComponent> OutComponents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ComponentTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ComponentClassFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = OutComponents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ComponentOverlapComponents, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutComponents = *(TArray<UPrimitiveComponent>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Component">
		/// Component to test with.
		/// </param>
		/// <param name="ComponentTransform">
		/// Defines where to place the component for overlap testing.
		/// </param>
		/// <param name="Filter">
		/// Option to restrict results to only static or only dynamic.  For efficiency.
		/// </param>
		/// <param name="ClassFilter">
		/// If set, will only return results of this class or subclasses of it.
		/// </param>
		/// <param name="ActorsToIgnore">
		/// Ignore these actors in the list
		/// </param>
		/// <param name="OutActors">
		/// Returned array of actors. Unsorted.
		/// </param>
		/// <returns>
		/// true if there was an overlap that passed the filters, false otherwise.
		/// </returns>
		public static bool ComponentOverlapActors(UPrimitiveComponent Component, FTransform ComponentTransform, TArray<EObjectTypeQuery> ObjectTypes, UClass ActorClassFilter, TArray<AActor> ActorsToIgnore, ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ComponentTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ActorClassFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ComponentOverlapActors, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void CollectGarbage()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __CollectGarbage);
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Radius">
		/// Radius of the capsule to sweep
		/// </param>
		/// <param name="HalfHeight">
		/// Distance from center of capsule to tip of hemisphere endcap.
		/// </param>
		/// <param name="ObjectTypes">
		/// Array of Object Types to trace 
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool CapsuleTraceSingleForObjects(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, TArray<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[79];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(float*)(__InBuffer + 28) = HalfHeight;

				*(nint*)(__InBuffer + 32) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 40) = bTraceComplex;

				*(nint*)(__InBuffer + 41) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 49) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 50) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 58) = bIgnoreSelf;

				*(nint*)(__InBuffer + 59) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 67) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 75) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CapsuleTraceSingleForObjects, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Radius">
		/// Radius of the capsule to sweep
		/// </param>
		/// <param name="HalfHeight">
		/// Distance from center of capsule to tip of hemisphere endcap.
		/// </param>
		/// <param name="ProfileName">
		/// The 'profile' used to determine which components to hit
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool CapsuleTraceSingleByProfile(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[79];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(float*)(__InBuffer + 28) = HalfHeight;

				*(nint*)(__InBuffer + 32) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 40) = bTraceComplex;

				*(nint*)(__InBuffer + 41) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 49) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 50) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 58) = bIgnoreSelf;

				*(nint*)(__InBuffer + 59) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 67) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 75) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CapsuleTraceSingleByProfile, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Radius">
		/// Radius of the capsule to sweep
		/// </param>
		/// <param name="HalfHeight">
		/// Distance from center of capsule to tip of hemisphere endcap.
		/// </param>
		/// <param name="TraceChannel">
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool CapsuleTraceSingle(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, ETraceTypeQuery TraceChannel, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[72];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(float*)(__InBuffer + 28) = HalfHeight;

				*(byte*)(__InBuffer + 32) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 33) = bTraceComplex;

				*(nint*)(__InBuffer + 34) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 42) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 43) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 51) = bIgnoreSelf;

				*(nint*)(__InBuffer + 52) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 60) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 68) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CapsuleTraceSingle, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Radius">
		/// Radius of the capsule to sweep
		/// </param>
		/// <param name="HalfHeight">
		/// Distance from center of capsule to tip of hemisphere endcap.
		/// </param>
		/// <param name="ObjectTypes">
		/// Array of Object Types to trace 
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHits">
		/// A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool CapsuleTraceMultiForObjects(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, TArray<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[79];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(float*)(__InBuffer + 28) = HalfHeight;

				*(nint*)(__InBuffer + 32) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 40) = bTraceComplex;

				*(nint*)(__InBuffer + 41) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 49) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 50) = OutHits?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 58) = bIgnoreSelf;

				*(nint*)(__InBuffer + 59) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 67) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 75) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CapsuleTraceMultiForObjects, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHits = *(TArray<FHitResult>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Radius">
		/// Radius of the capsule to sweep
		/// </param>
		/// <param name="HalfHeight">
		/// Distance from center of capsule to tip of hemisphere endcap.
		/// </param>
		/// <param name="ProfileName">
		/// The 'profile' used to determine which components to hit
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHits">
		/// A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
		/// </param>
		/// <returns>
		/// True if there was a blocking hit, false otherwise.
		/// </returns>
		public static bool CapsuleTraceMultiByProfile(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[79];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(float*)(__InBuffer + 28) = HalfHeight;

				*(nint*)(__InBuffer + 32) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 40) = bTraceComplex;

				*(nint*)(__InBuffer + 41) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 49) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 50) = OutHits?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 58) = bIgnoreSelf;

				*(nint*)(__InBuffer + 59) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 67) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 75) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CapsuleTraceMultiByProfile, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHits = *(TArray<FHitResult>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Radius">
		/// Radius of the capsule to sweep
		/// </param>
		/// <param name="HalfHeight">
		/// Distance from center of capsule to tip of hemisphere endcap.
		/// </param>
		/// <param name="TraceChannel">
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHits">
		/// A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
		/// </param>
		/// <returns>
		/// True if there was a blocking hit, false otherwise.
		/// </returns>
		public static bool CapsuleTraceMulti(UObject WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, ETraceTypeQuery TraceChannel, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[72];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Radius;

				*(float*)(__InBuffer + 28) = HalfHeight;

				*(byte*)(__InBuffer + 32) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 33) = bTraceComplex;

				*(nint*)(__InBuffer + 34) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 42) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 43) = OutHits?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 51) = bIgnoreSelf;

				*(nint*)(__InBuffer + 52) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 60) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 68) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CapsuleTraceMulti, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHits = *(TArray<FHitResult>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="CapsulePos">
		/// Center of the capsule.
		/// </param>
		/// <param name="Radius">
		/// Radius of capsule hemispheres and radius of center cylinder portion.
		/// </param>
		/// <param name="HalfHeight">
		/// Half-height of the capsule (from center of capsule to tip of hemisphere.
		/// </param>
		/// <param name="Filter">
		/// Option to restrict results to only static or only dynamic.  For efficiency.
		/// </param>
		/// <param name="ClassFilter">
		/// If set, will only return results of this class or subclasses of it.
		/// </param>
		/// <param name="ActorsToIgnore">
		/// Ignore these actors in the list
		/// </param>
		/// <param name="OutActors">
		/// Returned array of actors. Unsorted.
		/// </param>
		/// <returns>
		/// true if there was an overlap that passed the filters, false otherwise.
		/// </returns>
		public static bool CapsuleOverlapComponents(UObject WorldContextObject, FVector CapsulePos, float Radius, float HalfHeight, TArray<EObjectTypeQuery> ObjectTypes, UClass ComponentClassFilter, TArray<AActor> ActorsToIgnore, ref TArray<UPrimitiveComponent> OutComponents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[56];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CapsulePos?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Radius;

				*(float*)(__InBuffer + 20) = HalfHeight;

				*(nint*)(__InBuffer + 24) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ComponentClassFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = OutComponents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CapsuleOverlapComponents, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutComponents = *(TArray<UPrimitiveComponent>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="CapsulePos">
		/// Center of the capsule.
		/// </param>
		/// <param name="Radius">
		/// Radius of capsule hemispheres and radius of center cylinder portion.
		/// </param>
		/// <param name="HalfHeight">
		/// Half-height of the capsule (from center of capsule to tip of hemisphere.
		/// </param>
		/// <param name="Filter">
		/// Option to restrict results to only static or only dynamic.  For efficiency.
		/// </param>
		/// <param name="ClassFilter">
		/// If set, will only return results of this class or subclasses of it.
		/// </param>
		/// <param name="ActorsToIgnore">
		/// Ignore these actors in the list
		/// </param>
		/// <param name="OutActors">
		/// Returned array of actors. Unsorted.
		/// </param>
		/// <returns>
		/// true if there was an overlap that passed the filters, false otherwise.
		/// </returns>
		public static bool CapsuleOverlapActors(UObject WorldContextObject, FVector CapsulePos, float Radius, float HalfHeight, TArray<EObjectTypeQuery> ObjectTypes, UClass ActorClassFilter, TArray<AActor> ActorsToIgnore, ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[56];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CapsulePos?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Radius;

				*(float*)(__InBuffer + 20) = HalfHeight;

				*(nint*)(__InBuffer + 24) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ActorClassFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CapsuleOverlapActors, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool CanLaunchURL(FString URL)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = URL?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CanLaunchURL, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Only available in the editor.
		/// </note>
		/// <param name="Index">
		/// The action counter to cancel transactions from (as returned by a call to BeginTransaction).
		/// </param>
		public static void CancelTransaction(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __CancelTransaction, __InBuffer);
			}
		}

		public static void BreakTopLevelAssetPath(FTopLevelAssetPath TopLevelAssetPath, ref FString PathString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TopLevelAssetPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PathString?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakTopLevelAssetPath, __InBuffer, __OutBuffer);

				PathString = *(FString*)(__OutBuffer);

			}
		}

		public static void BreakSoftObjectPath(FSoftObjectPath InSoftObjectPath, ref FString PathString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InSoftObjectPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PathString?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakSoftObjectPath, __InBuffer, __OutBuffer);

				PathString = *(FString*)(__OutBuffer);

			}
		}

		public static void BreakSoftClassPath(FSoftClassPath InSoftClassPath, ref FString PathString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InSoftClassPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PathString?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakSoftClassPath, __InBuffer, __OutBuffer);

				PathString = *(FString*)(__OutBuffer);

			}
		}

		/// <param name="ClassNames">
		/// [DEPRECATED] - Class names are now represented by path names. Please use the ClassPaths output instead.
		/// </param>
		/// <param name="RecursiveClassesExclusionSet">
		/// [DEPRECATED] - Class names are now represented by path names. Please use the RecursiveClassPathsExclusionSet output instead.
		/// </param>
		public static void BreakARFilter(FARFilter InARFilter, ref TArray<FName> PackageNames, ref TArray<FName> PackagePaths, ref TArray<FSoftObjectPath> SoftObjectPaths, ref TArray<FTopLevelAssetPath> ClassPaths, ref TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet, ref TArray<FName> ClassNames, ref TSet<FName> RecursiveClassesExclusionSet, ref bool bRecursivePaths, ref bool bRecursiveClasses, ref bool bIncludeOnlyOnDiskAssets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[67];

				*(nint*)(__InBuffer) = InARFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PackageNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PackagePaths?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = SoftObjectPaths?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ClassPaths?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = RecursiveClassPathsExclusionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = ClassNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 56) = RecursiveClassesExclusionSet?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 64) = bRecursivePaths;

				*(bool*)(__InBuffer + 65) = bRecursiveClasses;

				*(bool*)(__InBuffer + 66) = bIncludeOnlyOnDiskAssets;

				var __OutBuffer = stackalloc byte[59];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakARFilter, __InBuffer, __OutBuffer);

				PackageNames = *(TArray<FName>*)(__OutBuffer);

				PackagePaths = *(TArray<FName>*)(__OutBuffer + 8);

				SoftObjectPaths = *(TArray<FSoftObjectPath>*)(__OutBuffer + 16);

				ClassPaths = *(TArray<FTopLevelAssetPath>*)(__OutBuffer + 24);

				RecursiveClassPathsExclusionSet = *(TSet<FTopLevelAssetPath>*)(__OutBuffer + 32);

				ClassNames = *(TArray<FName>*)(__OutBuffer + 40);

				RecursiveClassesExclusionSet = *(TSet<FName>*)(__OutBuffer + 48);

				bRecursivePaths = *(bool*)(__OutBuffer + 56);

				bRecursiveClasses = *(bool*)(__OutBuffer + 57);

				bIncludeOnlyOnDiskAssets = *(bool*)(__OutBuffer + 58);

			}
		}

		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Orientation">
		/// </param>
		/// <param name="HalfSize">
		/// Radius of the sphere to sweep
		/// </param>
		/// <param name="ObjectTypes">
		/// Array of Object Types to trace
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool BoxTraceSingleForObjects(UObject WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, TArray<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[87];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = HalfSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Orientation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 48) = bTraceComplex;

				*(nint*)(__InBuffer + 49) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 57) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 58) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 66) = bIgnoreSelf;

				*(nint*)(__InBuffer + 67) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 75) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 83) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __BoxTraceSingleForObjects, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="HalfSize">
		/// Distance from the center of box along each axis
		/// </param>
		/// <param name="Orientation">
		/// Orientation of the box
		/// </param>
		/// <param name="ProfileName">
		/// The 'profile' used to determine which components to hit
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool BoxTraceSingleByProfile(UObject WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[87];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = HalfSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Orientation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 48) = bTraceComplex;

				*(nint*)(__InBuffer + 49) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 57) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 58) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 66) = bIgnoreSelf;

				*(nint*)(__InBuffer + 67) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 75) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 83) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __BoxTraceSingleByProfile, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="HalfSize">
		/// Distance from the center of box along each axis
		/// </param>
		/// <param name="Orientation">
		/// Orientation of the box
		/// </param>
		/// <param name="TraceChannel">
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHit">
		/// Properties of the trace hit.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool BoxTraceSingle(UObject WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, ETraceTypeQuery TraceChannel, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[80];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = HalfSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Orientation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 41) = bTraceComplex;

				*(nint*)(__InBuffer + 42) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 50) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 51) = OutHit?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 59) = bIgnoreSelf;

				*(nint*)(__InBuffer + 60) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 68) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 76) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __BoxTraceSingle, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHit = *(FHitResult*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="Orientation">
		/// </param>
		/// <param name="HalfSize">
		/// Radius of the sphere to sweep
		/// </param>
		/// <param name="ObjectTypes">
		/// Array of Object Types to trace
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHits">
		/// A list of hits, sorted along the trace from start to finish.  The blocking hit will be the last hit, if there was one.
		/// </param>
		/// <returns>
		/// True if there was a hit, false otherwise.
		/// </returns>
		public static bool BoxTraceMultiForObjects(UObject WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, TArray<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[87];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = HalfSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Orientation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 48) = bTraceComplex;

				*(nint*)(__InBuffer + 49) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 57) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 58) = OutHits?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 66) = bIgnoreSelf;

				*(nint*)(__InBuffer + 67) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 75) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 83) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __BoxTraceMultiForObjects, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHits = *(TArray<FHitResult>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="HalfSize">
		/// Distance from the center of box along each axis
		/// </param>
		/// <param name="Orientation">
		/// Orientation of the box
		/// </param>
		/// <param name="ProfileName">
		/// The 'profile' used to determine which components to hit
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHits">
		/// A list of hits, sorted along the trace from start to finish. The blocking hit will be the last hit, if there was one.
		/// </param>
		/// <returns>
		/// True if there was a blocking hit, false otherwise.
		/// </returns>
		public static bool BoxTraceMultiByProfile(UObject WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[87];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = HalfSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Orientation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = ProfileName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 48) = bTraceComplex;

				*(nint*)(__InBuffer + 49) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 57) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 58) = OutHits?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 66) = bIgnoreSelf;

				*(nint*)(__InBuffer + 67) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 75) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 83) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __BoxTraceMultiByProfile, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHits = *(TArray<FHitResult>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Start">
		/// Start of line segment.
		/// </param>
		/// <param name="End">
		/// End of line segment.
		/// </param>
		/// <param name="HalfSize">
		/// Distance from the center of box along each axis
		/// </param>
		/// <param name="Orientation">
		/// Orientation of the box
		/// </param>
		/// <param name="TraceChannel">
		/// </param>
		/// <param name="bTraceComplex">
		/// True to test against complex collision, false to test against simplified collision.
		/// </param>
		/// <param name="OutHits">
		/// A list of hits, sorted along the trace from start to finish. The blocking hit will be the last hit, if there was one.
		/// </param>
		/// <returns>
		/// True if there was a blocking hit, false otherwise.
		/// </returns>
		public static bool BoxTraceMulti(UObject WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, ETraceTypeQuery TraceChannel, bool bTraceComplex, TArray<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, ref TArray<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[80];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Start?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = End?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = HalfSize?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Orientation?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 40) = (byte)TraceChannel;

				*(bool*)(__InBuffer + 41) = bTraceComplex;

				*(nint*)(__InBuffer + 42) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 50) = (byte)DrawDebugType;

				*(nint*)(__InBuffer + 51) = OutHits?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 59) = bIgnoreSelf;

				*(nint*)(__InBuffer + 60) = TraceColor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 68) = TraceHitColor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 76) = DrawTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __BoxTraceMulti, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutHits = *(TArray<FHitResult>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="BoxPos">
		/// Center of box.
		/// </param>
		/// <param name="BoxExtent">
		/// Extents of box.
		/// </param>
		/// <param name="Filter">
		/// Option to restrict results to only static or only dynamic.  For efficiency.
		/// </param>
		/// <param name="ClassFilter">
		/// If set, will only return results of this class or subclasses of it.
		/// </param>
		/// <param name="ActorsToIgnore">
		/// Ignore these actors in the list
		/// </param>
		/// <param name="OutActors">
		/// Returned array of actors. Unsorted.
		/// </param>
		/// <returns>
		/// true if there was an overlap that passed the filters, false otherwise.
		/// </returns>
		public static bool BoxOverlapComponents(UObject WorldContextObject, FVector BoxPos, FVector Extent, TArray<EObjectTypeQuery> ObjectTypes, UClass ComponentClassFilter, TArray<AActor> ActorsToIgnore, ref TArray<UPrimitiveComponent> OutComponents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[56];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoxPos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Extent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ComponentClassFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = OutComponents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __BoxOverlapComponents, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutComponents = *(TArray<UPrimitiveComponent>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="WorldContext">
		/// World context
		/// </param>
		/// <param name="BoxPos">
		/// Center of box.
		/// </param>
		/// <param name="BoxExtent">
		/// Extents of box.
		/// </param>
		/// <param name="Filter">
		/// Option to restrict results to only static or only dynamic.  For efficiency.
		/// </param>
		/// <param name="ClassFilter">
		/// If set, will only return results of this class or subclasses of it.
		/// </param>
		/// <param name="ActorsToIgnore">
		/// Ignore these actors in the list
		/// </param>
		/// <param name="OutActors">
		/// Returned array of actors. Unsorted.
		/// </param>
		/// <returns>
		/// true if there was an overlap that passed the filters, false otherwise.
		/// </returns>
		public static bool BoxOverlapActors(UObject WorldContextObject, FVector BoxPos, FVector BoxExtent, TArray<EObjectTypeQuery> ObjectTypes, UClass ActorClassFilter, TArray<AActor> ActorsToIgnore, ref TArray<AActor> OutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[56];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoxPos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ObjectTypes?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ActorClassFilter?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = ActorsToIgnore?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = OutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __BoxOverlapActors, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutActors = *(TArray<AActor>*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// If there is already an active transaction in progress, then this increments that transaction's action counter instead of beginning a new transaction.
		/// </note>
		/// <note>
		/// You must call TransactObject before modifying each object that should be included in this undo transaction.
		/// </note>
		/// <note>
		/// Only available in the editor.
		/// </note>
		/// <param name="Context">
		/// The context for the undo session. Typically the tool/editor that caused the undo operation.
		/// </param>
		/// <param name="Description">
		/// The description for the undo session. This is the text that will appear in the "Edit" menu next to the Undo item.
		/// </param>
		/// <param name="PrimaryObject">
		/// The primary object that the undo session operators on (can be null, and mostly is).
		/// </param>
		/// <returns>
		/// The number of active actions when BeginTransaction was called (values greater than 0 indicate that there was already an existing undo transaction in progress), or -1 on failure.
		/// </returns>
		public static int BeginTransaction(FString Context, FText Description, UObject PrimaryObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Description?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PrimaryObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __BeginTransaction, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FDebugFloatHistory AddFloatHistorySample(float Value, FDebugFloatHistory FloatHistory)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = Value;

				*(nint*)(__InBuffer + 4) = FloatHistory?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddFloatHistorySample, __InBuffer, __ReturnBuffer);

				return *(FDebugFloatHistory*)__ReturnBuffer;
			}
		}

		private static uint __UnregisterForRemoteNotifications = 0;

		private static uint __UnloadPrimaryAssetList = 0;

		private static uint __UnloadPrimaryAsset = 0;

		private static uint __TransactObject = 0;

		private static uint __StackTrace = 0;

		private static uint __SphereTraceSingleForObjects = 0;

		private static uint __SphereTraceSingleByProfile = 0;

		private static uint __SphereTraceSingle = 0;

		private static uint __SphereTraceMultiForObjects = 0;

		private static uint __SphereTraceMultiByProfile = 0;

		private static uint __SphereTraceMulti = 0;

		private static uint __SphereOverlapComponents = 0;

		private static uint __SphereOverlapActors = 0;

		private static uint __SnapshotObject = 0;

		private static uint __ShowPlatformSpecificLeaderboardScreen = 0;

		private static uint __ShowPlatformSpecificAchievementsScreen = 0;

		private static uint __ShowInterstitialAd = 0;

		private static uint __ShowAdBanner = 0;

		private static uint __SetWindowTitle = 0;

		private static uint __SetVolumeButtonsHandledBySystem = 0;

		private static uint __SetVectorPropertyByName = 0;

		private static uint __SetVector3fPropertyByName = 0;

		private static uint __SetUserActivity = 0;

		private static uint __SetTransformPropertyByName = 0;

		private static uint __SetTextPropertyByName = 0;

		private static uint __SetSuppressViewportTransitionMessage = 0;

		private static uint __SetStructurePropertyByName = 0;

		private static uint __SetStringPropertyByName = 0;

		private static uint __SetSoftObjectPropertyByName = 0;

		private static uint __SetSoftClassPropertyByName = 0;

		private static uint __SetRotatorPropertyByName = 0;

		private static uint __SetObjectPropertyByName = 0;

		private static uint __SetNamePropertyByName = 0;

		private static uint __SetLinearColorPropertyByName = 0;

		private static uint __SetIntPropertyByName = 0;

		private static uint __SetInterfacePropertyByName = 0;

		private static uint __SetInt64PropertyByName = 0;

		private static uint __SetGamepadsBlockDeviceFeedback = 0;

		private static uint __SetFieldPathPropertyByName = 0;

		private static uint __SetEditorProperty = 0;

		private static uint __SetDoublePropertyByName = 0;

		private static uint __SetColorPropertyByName = 0;

		private static uint __SetCollisionProfileNameProperty = 0;

		private static uint __SetClassPropertyByName = 0;

		private static uint __SetBytePropertyByName = 0;

		private static uint __SetBoolPropertyByName = 0;

		private static uint __RetriggerableDelay = 0;

		private static uint __ResetGamepadAssignmentToController = 0;

		private static uint __ResetGamepadAssignments = 0;

		private static uint __RegisterForRemoteNotifications = 0;

		private static uint __QuitGame = 0;

		private static uint __QuitEditor = 0;

		private static uint __PrintWarning = 0;

		private static uint __PrintText = 0;

		private static uint __PrintString = 0;

		private static uint __ParseParamValue = 0;

		private static uint __ParseParam = 0;

		private static uint __ParseCommandLine = 0;

		private static uint __NotEqual_SoftObjectReference = 0;

		private static uint __NotEqual_SoftClassReference = 0;

		private static uint __NotEqual_PrimaryAssetType = 0;

		private static uint __NotEqual_PrimaryAssetId = 0;

		private static uint __NormalizeFilename = 0;

		private static uint __MoveComponentTo = 0;

		private static uint __MakeTopLevelAssetPath = 0;

		private static uint __MakeSoftObjectPath = 0;

		private static uint __MakeSoftClassPath = 0;

		private static uint __MakeLiteralText = 0;

		private static uint __MakeLiteralString = 0;

		private static uint __MakeLiteralName = 0;

		private static uint __MakeLiteralInt64 = 0;

		private static uint __MakeLiteralInt = 0;

		private static uint __MakeLiteralDouble = 0;

		private static uint __MakeLiteralByte = 0;

		private static uint __MakeLiteralBool = 0;

		private static uint __MakeARFilter = 0;

		private static uint __LogString = 0;

		private static uint __LoadInterstitialAd = 0;

		private static uint __LoadClassAsset_Blocking = 0;

		private static uint __LoadAssetClass = 0;

		private static uint __LoadAsset_Blocking = 0;

		private static uint __LoadAsset = 0;

		private static uint __LineTraceSingleForObjects = 0;

		private static uint __LineTraceSingleByProfile = 0;

		private static uint __LineTraceSingle = 0;

		private static uint __LineTraceMultiForObjects = 0;

		private static uint __LineTraceMultiByProfile = 0;

		private static uint __LineTraceMulti = 0;

		private static uint __LaunchURL = 0;

		private static uint __K2_UnPauseTimerHandle = 0;

		private static uint __K2_UnPauseTimerDelegate = 0;

		private static uint __K2_UnPauseTimer = 0;

		private static uint __K2_TimerExistsHandle = 0;

		private static uint __K2_TimerExistsDelegate = 0;

		private static uint __K2_TimerExists = 0;

		private static uint __K2_SetTimerForNextTickDelegate = 0;

		private static uint __K2_SetTimerForNextTick = 0;

		private static uint __K2_SetTimerDelegate = 0;

		private static uint __K2_SetTimer = 0;

		private static uint __K2_PauseTimerHandle = 0;

		private static uint __K2_PauseTimerDelegate = 0;

		private static uint __K2_PauseTimer = 0;

		private static uint __K2_IsValidTimerHandle = 0;

		private static uint __K2_IsTimerPausedHandle = 0;

		private static uint __K2_IsTimerPausedDelegate = 0;

		private static uint __K2_IsTimerPaused = 0;

		private static uint __K2_IsTimerActiveHandle = 0;

		private static uint __K2_IsTimerActiveDelegate = 0;

		private static uint __K2_IsTimerActive = 0;

		private static uint __K2_InvalidateTimerHandle = 0;

		private static uint __K2_GetTimerRemainingTimeHandle = 0;

		private static uint __K2_GetTimerRemainingTimeDelegate = 0;

		private static uint __K2_GetTimerRemainingTime = 0;

		private static uint __K2_GetTimerElapsedTimeHandle = 0;

		private static uint __K2_GetTimerElapsedTimeDelegate = 0;

		private static uint __K2_GetTimerElapsedTime = 0;

		private static uint __K2_ClearTimerHandle = 0;

		private static uint __K2_ClearTimerDelegate = 0;

		private static uint __K2_ClearTimer = 0;

		private static uint __K2_ClearAndInvalidateTimerHandle = 0;

		private static uint __IsValidSoftObjectReference = 0;

		private static uint __IsValidSoftClassReference = 0;

		private static uint __IsValidPrimaryAssetType = 0;

		private static uint __IsValidPrimaryAssetId = 0;

		private static uint __IsValidClass = 0;

		private static uint __IsValid = 0;

		private static uint __IsUnattended = 0;

		private static uint __IsStandalone = 0;

		private static uint __IsSplitScreen = 0;

		private static uint __IsServer = 0;

		private static uint __IsScreensaverEnabled = 0;

		private static uint __IsPackagedForDistribution = 0;

		private static uint __IsLoggedIn = 0;

		private static uint __IsInterstitialAdRequested = 0;

		private static uint __IsInterstitialAdAvailable = 0;

		private static uint __IsDedicatedServer = 0;

		private static uint __IsControllerAssignedToGamepad = 0;

		private static uint __HideAdBanner = 0;

		private static uint __HasMultipleLocalPlayers = 0;

		private static uint __GetVolumeButtonsHandledBySystem = 0;

		private static uint __GetUniqueDeviceId = 0;

		private static uint __GetSystemPath = 0;

		private static uint __GetSupportedFullscreenResolutions = 0;

		private static uint __GetStructTopLevelAssetPath = 0;

		private static uint __GetSoftObjectReferenceFromPrimaryAssetId = 0;

		private static uint __GetSoftObjectPath = 0;

		private static uint __GetSoftClassTopLevelAssetPath = 0;

		private static uint __GetSoftClassReferenceFromPrimaryAssetId = 0;

		private static uint __GetSoftClassPath = 0;

		private static uint __GetRenderingMaterialQualityLevel = 0;

		private static uint __GetRenderingDetailMode = 0;

		private static uint __GetProjectSavedDirectory = 0;

		private static uint __GetProjectDirectory = 0;

		private static uint __GetProjectContentDirectory = 0;

		private static uint __GetPrimaryAssetsWithBundleState = 0;

		private static uint __GetPrimaryAssetIdList = 0;

		private static uint __GetPrimaryAssetIdFromSoftObjectReference = 0;

		private static uint __GetPrimaryAssetIdFromSoftClassReference = 0;

		private static uint __GetPrimaryAssetIdFromObject = 0;

		private static uint __GetPrimaryAssetIdFromClass = 0;

		private static uint __GetPreferredLanguages = 0;

		private static uint __GetPlatformUserName = 0;

		private static uint __GetPlatformUserDir = 0;

		private static uint __GetPlatformTime_Seconds = 0;

		private static uint __GetPathName = 0;

		private static uint __GetOuterObject = 0;

		private static uint __GetObjectName = 0;

		private static uint __GetObjectFromPrimaryAssetId = 0;

		private static uint __GetMinYResolutionForUI = 0;

		private static uint __GetMinYResolutionFor3DView = 0;

		private static uint __GetLocalCurrencySymbol = 0;

		private static uint __GetLocalCurrencyCode = 0;

		private static uint __GetGameTimeInSeconds = 0;

		private static uint __GetGamepadControllerName = 0;

		private static uint __GetGamepadButtonGlyph = 0;

		private static uint __GetGameName = 0;

		private static uint __GetGameBundleId = 0;

		private static uint __GetFrameCount = 0;

		private static uint __GetEnumTopLevelAssetPath = 0;

		private static uint __GetEngineVersion = 0;

		private static uint __GetEditorProperty = 0;

		private static uint __GetDisplayName = 0;

		private static uint __GetDeviceId = 0;

		private static uint __GetDefaultLocale = 0;

		private static uint __GetDefaultLanguage = 0;

		private static uint __GetCurrentBundleState = 0;

		private static uint __GetConvenientWindowedResolutions = 0;

		private static uint __GetConsoleVariableStringValue = 0;

		private static uint __GetConsoleVariableIntValue = 0;

		private static uint __GetConsoleVariableFloatValue = 0;

		private static uint __GetConsoleVariableBoolValue = 0;

		private static uint __GetComponentBounds = 0;

		private static uint __GetCommandLine = 0;

		private static uint __GetClassTopLevelAssetPath = 0;

		private static uint __GetClassFromPrimaryAssetId = 0;

		private static uint __GetClassDisplayName = 0;

		private static uint __GetBuildVersion = 0;

		private static uint __GetBuildConfiguration = 0;

		private static uint __GetAdIDCount = 0;

		private static uint __GetActorListFromComponentList = 0;

		private static uint __GetActorBounds = 0;

		private static uint __ForceCloseAdBanner = 0;

		private static uint __FlushPersistentDebugLines = 0;

		private static uint __FlushDebugStrings = 0;

		private static uint __ExecuteConsoleCommand = 0;

		private static uint __EqualEqual_SoftObjectReference = 0;

		private static uint __EqualEqual_SoftClassReference = 0;

		private static uint __EqualEqual_PrimaryAssetType = 0;

		private static uint __EqualEqual_PrimaryAssetId = 0;

		private static uint __EndTransaction = 0;

		private static uint __DrawDebugString = 0;

		private static uint __DrawDebugSphere = 0;

		private static uint __DrawDebugPoint = 0;

		private static uint __DrawDebugPlane = 0;

		private static uint __DrawDebugLine = 0;

		private static uint __DrawDebugFrustum = 0;

		private static uint __DrawDebugFloatHistoryTransform = 0;

		private static uint __DrawDebugFloatHistoryLocation = 0;

		private static uint __DrawDebugCylinder = 0;

		private static uint __DrawDebugCoordinateSystem = 0;

		private static uint __DrawDebugConeInDegrees = 0;

		private static uint __DrawDebugCone = 0;

		private static uint __DrawDebugCircle = 0;

		private static uint __DrawDebugCapsule = 0;

		private static uint __DrawDebugCamera = 0;

		private static uint __DrawDebugBox = 0;

		private static uint __DrawDebugArrow = 0;

		private static uint __DoesImplementInterface = 0;

		private static uint __DelayUntilNextTick = 0;

		private static uint __Delay = 0;

		private static uint __CreateCopyForUndoBuffer = 0;

		private static uint __ConvertToRelativePath = 0;

		private static uint __ConvertToAbsolutePath = 0;

		private static uint __Conv_SoftObjRefToSoftObjPath = 0;

		private static uint __Conv_SoftObjRefToSoftClassPath = 0;

		private static uint __Conv_SoftObjPathToSoftObjRef = 0;

		private static uint __Conv_SoftObjectReferenceToString = 0;

		private static uint __Conv_SoftObjectReferenceToObject = 0;

		private static uint __Conv_SoftClassReferenceToString = 0;

		private static uint __Conv_SoftClassReferenceToClass = 0;

		private static uint __Conv_SoftClassPathToSoftClassRef = 0;

		private static uint __Conv_PrimaryAssetTypeToString = 0;

		private static uint __Conv_PrimaryAssetIdToString = 0;

		private static uint __Conv_ObjectToSoftObjectReference = 0;

		private static uint __Conv_ObjectToClass = 0;

		private static uint __Conv_InterfaceToObject = 0;

		private static uint __Conv_ComponentReferenceToSoftComponentReference = 0;

		private static uint __Conv_ClassToSoftClassReference = 0;

		private static uint __ControlScreensaver = 0;

		private static uint __ComponentOverlapComponents = 0;

		private static uint __ComponentOverlapActors = 0;

		private static uint __CollectGarbage = 0;

		private static uint __CapsuleTraceSingleForObjects = 0;

		private static uint __CapsuleTraceSingleByProfile = 0;

		private static uint __CapsuleTraceSingle = 0;

		private static uint __CapsuleTraceMultiForObjects = 0;

		private static uint __CapsuleTraceMultiByProfile = 0;

		private static uint __CapsuleTraceMulti = 0;

		private static uint __CapsuleOverlapComponents = 0;

		private static uint __CapsuleOverlapActors = 0;

		private static uint __CanLaunchURL = 0;

		private static uint __CancelTransaction = 0;

		private static uint __BreakTopLevelAssetPath = 0;

		private static uint __BreakSoftObjectPath = 0;

		private static uint __BreakSoftClassPath = 0;

		private static uint __BreakARFilter = 0;

		private static uint __BoxTraceSingleForObjects = 0;

		private static uint __BoxTraceSingleByProfile = 0;

		private static uint __BoxTraceSingle = 0;

		private static uint __BoxTraceMultiForObjects = 0;

		private static uint __BoxTraceMultiByProfile = 0;

		private static uint __BoxTraceMulti = 0;

		private static uint __BoxOverlapComponents = 0;

		private static uint __BoxOverlapActors = 0;

		private static uint __BeginTransaction = 0;

		private static uint __AddFloatHistorySample = 0;
	}
}