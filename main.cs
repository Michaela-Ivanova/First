Comit1
comit 2
comit 3 

ConveyourBeltOff
ConveyorBeltRunning
ConveyorBeltTrottled 
RunningEmpty
StoppedConveyour 

Type1Detected
Type2Detected
Timer1RunOut
Timer1Reset
TrotlingEndedTimer
TurnOnConveyour 
StartAgainConveyour


Type2DetectredSortingAction
Type1DetectredSortingAction


initialState ConveyourBeltOff {
TurnOnConveyour -> ConveyorBeltRunning -> DetectItems
...

}

ConveyorBeltRunning {
  {init Timer1RunOut}
  Type1Detected -> ConveyorBeltTrottled -> {Type1DetectredSortingAction, TrotlingEndedTimer, Timer1Reset}
  Type2Detected -> ConveyorBeltTrottled -> {Type2DetectredSortingAction, TrotlingEndedTimer, Timer1Reset}
}

ConveyorBeltTrottled {
  TrotlingEndedTimer -> ConveyorBeltRunning -> {}
}