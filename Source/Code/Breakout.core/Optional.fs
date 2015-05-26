module Optional
open Duality

let OptionComponent<'t when 't :> Component 
                        and 't : not struct 
                        and 't : null> (go: GameObject)  = match go.GetComponent<'t>() with
                                                            | null -> None
                                                            | line -> Some line
let OptionComponent'<'t when 't :> Component 
                         and 't : not struct > (go: GameObject)  = match go.GetComponent<'t>() with                                                            
                                                            | line when box line <> null -> Some line
                                                            | _ -> None

let FindComponent<'t when 't :null  
                     and 't :> Component 
                     and 't : not struct> (scene: Resources.Scene)  = 
                    match scene.FindComponent<'t>() with            
                    | null -> None
                    | a -> Some a
                    