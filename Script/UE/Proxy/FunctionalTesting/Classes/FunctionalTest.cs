using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.FunctionalTesting
{
	[PathName("/Script/FunctionalTesting.FunctionalTest")]
	public partial class AFunctionalTest : AActor, IStaticClass
	{
		public FString TestLabel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TestLabel, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TestLabel, __InBuffer);
				}
			}
		}

		public FString Author
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Author, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Author, __InBuffer);
				}
			}
		}

		public FString Description
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Description, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Description, __InBuffer);
				}
			}
		}

		public UBillboardComponent SpriteComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteComponent, __ReturnBuffer);

					return *(UBillboardComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteComponent, __InBuffer);
				}
			}
		}

		public bool bIsEnabled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabled, __InBuffer);
				}
			}
		}

		public EFunctionalTestLogHandling LogErrorHandling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LogErrorHandling, __ReturnBuffer);

					return *(EFunctionalTestLogHandling*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LogErrorHandling, __InBuffer);
				}
			}
		}

		public EFunctionalTestLogHandling LogWarningHandling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LogWarningHandling, __ReturnBuffer);

					return *(EFunctionalTestLogHandling*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LogWarningHandling, __InBuffer);
				}
			}
		}

		public AActor ObservationPoint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObservationPoint, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObservationPoint, __InBuffer);
				}
			}
		}

		public FRandomStream RandomNumbersStream
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RandomNumbersStream, __ReturnBuffer);

					return *(FRandomStream*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RandomNumbersStream, __InBuffer);
				}
			}
		}

		public EFunctionalTestResult Result
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Result, __ReturnBuffer);

					return *(EFunctionalTestResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Result, __InBuffer);
				}
			}
		}

		public float PreparationTimeLimit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreparationTimeLimit, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreparationTimeLimit, __InBuffer);
				}
			}
		}

		public float TimeLimit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TimeLimit, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TimeLimit, __InBuffer);
				}
			}
		}

		public FText TimesUpMessage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TimesUpMessage, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TimesUpMessage, __InBuffer);
				}
			}
		}

		public EFunctionalTestResult TimesUpResult
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TimesUpResult, __ReturnBuffer);

					return *(EFunctionalTestResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TimesUpResult, __InBuffer);
				}
			}
		}

		public FFunctionalTestEventSignature OnTestPrepare
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTestPrepare, __ReturnBuffer);

					return *(FFunctionalTestEventSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTestPrepare, __InBuffer);
				}
			}
		}

		public FFunctionalTestEventSignature OnTestStart
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTestStart, __ReturnBuffer);

					return *(FFunctionalTestEventSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTestStart, __InBuffer);
				}
			}
		}

		public FFunctionalTestEventSignature OnTestFinished
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTestFinished, __ReturnBuffer);

					return *(FFunctionalTestEventSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTestFinished, __InBuffer);
				}
			}
		}

		public TArray<AActor> AutoDestroyActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoDestroyActors, __ReturnBuffer);

					return *(TArray<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoDestroyActors, __InBuffer);
				}
			}
		}

		public UFuncTestRenderingComponent RenderComp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RenderComp, __ReturnBuffer);

					return *(UFuncTestRenderingComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RenderComp, __InBuffer);
				}
			}
		}

		public UTextRenderComponent TestName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TestName, __ReturnBuffer);

					return *(UTextRenderComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TestName, __InBuffer);
				}
			}
		}

		public bool bIsRunning
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsRunning, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsRunning, __InBuffer);
				}
			}
		}

		public float TotalTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TotalTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TotalTime, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FunctionalTesting.FunctionalTest");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetTimeLimit(float NewTimeLimit, EFunctionalTestResult ResultWhenTimeRunsOut)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = NewTimeLimit;

				*(byte*)(__InBuffer + 4) = (byte)ResultWhenTimeRunsOut;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTimeLimit, __InBuffer);
			}
		}

		public virtual void SetConsoleVariableFromInteger(FString Name, int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConsoleVariableFromInteger, __InBuffer);
			}
		}

		public virtual void SetConsoleVariableFromFloat(FString Name, float InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConsoleVariableFromFloat, __InBuffer);
			}
		}

		public virtual void SetConsoleVariableFromBoolean(FString Name, bool InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConsoleVariableFromBoolean, __InBuffer);
			}
		}

		public virtual void SetConsoleVariable(FString Name, FString InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConsoleVariable, __InBuffer);
			}
		}

		public virtual void RegisterAutoDestroyActor(AActor ActorToAutoDestroy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorToAutoDestroy?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RegisterAutoDestroyActor, __InBuffer);
			}
		}

		public virtual void ReceiveStartTest()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceiveStartTest);
			}
		}

		public virtual void ReceivePrepareTest()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceivePrepareTest);
			}
		}

		public virtual bool OnWantsReRunCheck()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall1Implementation(GarbageCollectionHandle, __OnWantsReRunCheck, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FString OnAdditionalTestFinishedMessageRequest(EFunctionalTestResult TestResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)TestResult;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall3Implementation(GarbageCollectionHandle, __OnAdditionalTestFinishedMessageRequest, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual void LogMessage(FString Message)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Message?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __LogMessage, __InBuffer);
			}
		}

		public virtual bool IsRunning()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsRunning, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsReady()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsReady, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FName GetCurrentRerunReason()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentRerunReason, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual void FinishTest(EFunctionalTestResult TestResult, FString Message)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)TestResult;

				*(nint*)(__InBuffer + 1) = Message?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FinishTest, __InBuffer);
			}
		}

		public virtual TArray<AActor> DebugGatherRelevantActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall1Implementation(GarbageCollectionHandle, __DebugGatherRelevantActors, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails (What: expected {Actual} to be <ShouldBe> {Expected} for context '')
		/// </param>
		public virtual bool AssertValue_Int(int Actual, EComparisonMethod ShouldBe, int Expected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(int*)(__InBuffer) = Actual;

				*(byte*)(__InBuffer + 4) = (byte)ShouldBe;

				*(int*)(__InBuffer + 5) = Expected;

				*(nint*)(__InBuffer + 9) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertValue_Int, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails (What: expected {Actual} to be <ShouldBe> {Expected} for context '')
		/// </param>
		public virtual bool AssertValue_Float(float Actual, EComparisonMethod ShouldBe, float Expected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(float*)(__InBuffer) = Actual;

				*(byte*)(__InBuffer + 4) = (byte)ShouldBe;

				*(float*)(__InBuffer + 5) = Expected;

				*(nint*)(__InBuffer + 9) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertValue_Float, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails (What: expected {Actual} to be <ShouldBe> {Expected} for context '')
		/// </param>
		public virtual bool AssertValue_Double(double Actual, EComparisonMethod ShouldBe, double Expected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(double*)(__InBuffer) = Actual;

				*(byte*)(__InBuffer + 8) = (byte)ShouldBe;

				*(double*)(__InBuffer + 9) = Expected;

				*(nint*)(__InBuffer + 17) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertValue_Double, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails (What: expected {Actual} to be <ShouldBe> {Expected} for context '')
		/// </param>
		public virtual bool AssertValue_DateTime(FDateTime Actual, EComparisonMethod ShouldBe, FDateTime Expected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ShouldBe;

				*(nint*)(__InBuffer + 9) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertValue_DateTime, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Message">
		/// The message to display if the assert fails ("Assertion Failed: 'Message' for context ''")
		/// </param>
		public virtual bool AssertTrue(bool Condition, FString Message, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(bool*)(__InBuffer) = Condition;

				*(nint*)(__InBuffer + 1) = Message?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertTrue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertNotEqual_Vector4(FVector4 Actual, FVector4 NotExpected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotExpected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertNotEqual_Vector4, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertNotEqual_Vector2D(FVector2D Actual, FVector2D NotExpected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotExpected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertNotEqual_Vector2D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertNotEqual_Vector(FVector Actual, FVector NotExpected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotExpected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertNotEqual_Vector, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertNotEqual_Transform(FTransform Actual, FTransform NotExpected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotExpected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertNotEqual_Transform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertNotEqual_String(FString Actual, FString NotExpected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotExpected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertNotEqual_String, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertNotEqual_Rotator(FRotator Actual, FRotator NotExpected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotExpected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertNotEqual_Rotator, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertNotEqual_Quat(FQuat Actual, FQuat NotExpected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotExpected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertNotEqual_Quat, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertNotEqual_Plane(FPlane Actual, FPlane NotExpected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotExpected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertNotEqual_Plane, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertNotEqual_Matrix(FMatrix Actual, FMatrix NotExpected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotExpected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertNotEqual_Matrix, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertNotEqual_Box2D(FBox2D Actual, FBox2D NotExpected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotExpected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertNotEqual_Box2D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Message">
		/// The message to display if the object is invalid ("Invalid object: 'Message' for context ''")
		/// </param>
		public virtual bool AssertIsValid(UObject Object, FString Message, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Message?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertIsValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Message">
		/// The message to display if the assert fails ("Assertion Failed: 'Message' for context ''")
		/// </param>
		public virtual bool AssertFalse(bool Condition, FString Message, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(bool*)(__InBuffer) = Condition;

				*(nint*)(__InBuffer + 1) = Message?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertFalse, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertEqual_Vector4(FVector4 Actual, FVector4 Expected, FString What, float Tolerance = 0.000100f, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Tolerance;

				*(nint*)(__InBuffer + 28) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Vector4, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertEqual_Vector2D(FVector2D Actual, FVector2D Expected, FString What, float Tolerance = 0.000100f, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Tolerance;

				*(nint*)(__InBuffer + 28) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Vector2D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertEqual_Vector(FVector Actual, FVector Expected, FString What, float Tolerance = 0.000100f, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Tolerance;

				*(nint*)(__InBuffer + 28) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Vector, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertEqual_Transform(FTransform Actual, FTransform Expected, FString What, float Tolerance = 0.000100f, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Tolerance;

				*(nint*)(__InBuffer + 28) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Transform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' not to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertEqual_TraceQueryResults(UTraceQueryTestResults Actual, UTraceQueryTestResults Expected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_TraceQueryResults, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertEqual_String(FString Actual, FString Expected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_String, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertEqual_Rotator(FRotator Actual, FRotator Expected, FString What, float Tolerance = 0.000100f, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Tolerance;

				*(nint*)(__InBuffer + 28) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Rotator, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertEqual_Quat(FQuat Actual, FQuat Expected, FString What, float Tolerance = 0.000100f, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Tolerance;

				*(nint*)(__InBuffer + 28) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Quat, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertEqual_Plane(FPlane Actual, FPlane Expected, FString What, float Tolerance = 0.000100f, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Tolerance;

				*(nint*)(__InBuffer + 28) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Plane, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails (What: expected {Actual} to be Equal To {Expected} for context '')
		/// </param>
		public virtual bool AssertEqual_Object(UObject Actual, UObject Expected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Object, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails (What: expected {Actual} to be Equal To {Expected} for context '')
		/// </param>
		public virtual bool AssertEqual_Name(FName Actual, FName Expected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Name, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertEqual_Matrix(FMatrix Actual, FMatrix Expected, FString What, float Tolerance = 0.000100f, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Tolerance;

				*(nint*)(__InBuffer + 28) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Matrix, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails (What: expected {Actual} to be Equal To {Expected} for context '')
		/// </param>
		public virtual bool AssertEqual_Int(int Actual, int Expected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(int*)(__InBuffer) = Actual;

				*(int*)(__InBuffer + 4) = Expected;

				*(nint*)(__InBuffer + 8) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Int, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails (What: expected {Actual} to be Equal To {Expected} within Tolerance for context '')
		/// </param>
		public virtual bool AssertEqual_Float(float Actual, float Expected, FString What, float Tolerance = 0.000100f, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(float*)(__InBuffer) = Actual;

				*(float*)(__InBuffer + 4) = Expected;

				*(nint*)(__InBuffer + 8) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Tolerance;

				*(nint*)(__InBuffer + 20) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Float, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails (What: expected {Actual} to be Equal To {Expected} within Tolerance for context '')
		/// </param>
		public virtual bool AssertEqual_Double(double Actual, double Expected, FString What, double Tolerance = 0.000100, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(double*)(__InBuffer) = Actual;

				*(double*)(__InBuffer + 8) = Expected;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 24) = Tolerance;

				*(nint*)(__InBuffer + 32) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Double, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails ("Expected 'What' to be {Expected} but it was {Actual} for context ''")
		/// </param>
		public virtual bool AssertEqual_Box2D(FBox2D Actual, FBox2D Expected, FString What, float Tolerance = 0.000100f, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(nint*)(__InBuffer) = Actual?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Expected?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 24) = Tolerance;

				*(nint*)(__InBuffer + 28) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Box2D, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="What">
		/// A name to use in the message if the assert fails (What: expected {Actual} to be Equal To {Expected} for context '')
		/// </param>
		public virtual bool AssertEqual_Bool(bool Actual, bool Expected, FString What, UObject ContextObject = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(bool*)(__InBuffer) = Actual;

				*(bool*)(__InBuffer + 1) = Expected;

				*(nint*)(__InBuffer + 2) = What?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 10) = ContextObject?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AssertEqual_Bool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void AddWarning(FString Message)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Message?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddWarning, __InBuffer);
			}
		}

		public virtual void AddRerun(FName Reason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Reason?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddRerun, __InBuffer);
			}
		}

		public virtual void AddInfo(FString Message)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Message?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddInfo, __InBuffer);
			}
		}

		public virtual void AddError(FString Message)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Message?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddError, __InBuffer);
			}
		}

		private static uint __TestLabel = 0;

		private static uint __Author = 0;

		private static uint __Description = 0;

		private static uint __SpriteComponent = 0;

		private static uint __bIsEnabled = 0;

		private static uint __LogErrorHandling = 0;

		private static uint __LogWarningHandling = 0;

		private static uint __ObservationPoint = 0;

		private static uint __RandomNumbersStream = 0;

		private static uint __Result = 0;

		private static uint __PreparationTimeLimit = 0;

		private static uint __TimeLimit = 0;

		private static uint __TimesUpMessage = 0;

		private static uint __TimesUpResult = 0;

		private static uint __OnTestPrepare = 0;

		private static uint __OnTestStart = 0;

		private static uint __OnTestFinished = 0;

		private static uint __AutoDestroyActors = 0;

		private static uint __RenderComp = 0;

		private static uint __TestName = 0;

		private static uint __bIsRunning = 0;

		private static uint __TotalTime = 0;

		private static uint __SetTimeLimit = 0;

		private static uint __SetConsoleVariableFromInteger = 0;

		private static uint __SetConsoleVariableFromFloat = 0;

		private static uint __SetConsoleVariableFromBoolean = 0;

		private static uint __SetConsoleVariable = 0;

		private static uint __RegisterAutoDestroyActor = 0;

		private static uint __ReceiveStartTest = 0;

		private static uint __ReceivePrepareTest = 0;

		private static uint __OnWantsReRunCheck = 0;

		private static uint __OnAdditionalTestFinishedMessageRequest = 0;

		private static uint __LogMessage = 0;

		private static uint __IsRunning = 0;

		private static uint __IsReady = 0;

		private static uint __IsEnabled = 0;

		private static uint __GetCurrentRerunReason = 0;

		private static uint __FinishTest = 0;

		private static uint __DebugGatherRelevantActors = 0;

		private static uint __AssertValue_Int = 0;

		private static uint __AssertValue_Float = 0;

		private static uint __AssertValue_Double = 0;

		private static uint __AssertValue_DateTime = 0;

		private static uint __AssertTrue = 0;

		private static uint __AssertNotEqual_Vector4 = 0;

		private static uint __AssertNotEqual_Vector2D = 0;

		private static uint __AssertNotEqual_Vector = 0;

		private static uint __AssertNotEqual_Transform = 0;

		private static uint __AssertNotEqual_String = 0;

		private static uint __AssertNotEqual_Rotator = 0;

		private static uint __AssertNotEqual_Quat = 0;

		private static uint __AssertNotEqual_Plane = 0;

		private static uint __AssertNotEqual_Matrix = 0;

		private static uint __AssertNotEqual_Box2D = 0;

		private static uint __AssertIsValid = 0;

		private static uint __AssertFalse = 0;

		private static uint __AssertEqual_Vector4 = 0;

		private static uint __AssertEqual_Vector2D = 0;

		private static uint __AssertEqual_Vector = 0;

		private static uint __AssertEqual_Transform = 0;

		private static uint __AssertEqual_TraceQueryResults = 0;

		private static uint __AssertEqual_String = 0;

		private static uint __AssertEqual_Rotator = 0;

		private static uint __AssertEqual_Quat = 0;

		private static uint __AssertEqual_Plane = 0;

		private static uint __AssertEqual_Object = 0;

		private static uint __AssertEqual_Name = 0;

		private static uint __AssertEqual_Matrix = 0;

		private static uint __AssertEqual_Int = 0;

		private static uint __AssertEqual_Float = 0;

		private static uint __AssertEqual_Double = 0;

		private static uint __AssertEqual_Box2D = 0;

		private static uint __AssertEqual_Bool = 0;

		private static uint __AddWarning = 0;

		private static uint __AddRerun = 0;

		private static uint __AddInfo = 0;

		private static uint __AddError = 0;
	}
}