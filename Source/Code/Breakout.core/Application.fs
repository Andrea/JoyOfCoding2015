namespace Breakout
open Duality 
open Duality.Resources 
open Optional
open OpenTK.Input
open OpenTK


type Application() = 
    inherit Component() 

    interface ICmpUpdatable with 
        member this.OnUpdate() =             
            if (DualityApp.Keyboard.KeyPressed(Key.Space))  then
                
                let ball = FindComponent<Ball> Scene.Current
                let lifeMeter = FindComponent<LifeMeter> Scene.Current
            
                match lifeMeter, ball with
                | None, None -> Log.Game.Write "Didn't find life meter or ball"
                | None, _ -> Log.Game.Write "Didn't find life meter "
                | _, None -> Log.Game.Write "Didn't find ball"
                | Some l , Some b when l.Lives > 0 && b.BallState = BallState.FixedToBat ->
                    ball.Value.GameObj.RigidBody.LinearVelocity <- new Vector2((float32) ((MathF.Rnd.NextDouble() - 0.5)* 2.0 *100.0), -100.0f)
                    ball.Value.BallState <- BallState.Free
                | _, _ -> ()


