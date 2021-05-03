<script>
  import { link } from "svelte-routing";
  import { authenticate } from "../helpers";
import axios from "axios";

  const logout = async () => {
    try{
            const res = await axios({
                method: "POST",
                withCredentials: true,
                url: "https://localhost:44377/api/auth/logout",
            });

            if(res.status === 200){
                alert("Successful Logout");
                window.location.assign("/");
            }

        }catch(err){
            alert(err);
        }

  }
</script>

    <nav>
        <h1><a href="/dashboard" use:link>The Projector</a></h1>
        <div>
            <ul>
                {#if window.location.href !== "http://localhost:5000/"}
                    <li><a href="/projects" use:link>Add Project</a></li>
                    <li><a href="/peoples" use:link>Add Person</a></li>
                    <li><a href="/" class="btn btn--primary" style="color: #ff3e00" on:click={logout}>Log Out</a></li>
                    
                {/if}
            </ul>                
            
        </div>
    </nav>

<style>
    nav{
        background-color: #ff3e00;
        height: 120px;
        width:inherit;
        padding: 0 3.2rem;
        position:absolute;
        left: 0;
        top:0;
        display: flex;
        align-items: center;
        justify-content: space-between;

    }
    ul{
        list-style-type: none;
        display: inline-block;
    }

    ul li{
        display: inline-block;
        margin: 1.6rem;
        text-transform: uppercase;
    }

    ul li a, a{
        color: #Fff;
        opacity: 0.8;
        transition: all .4s;
    }

    ul li a:hover, a{
        opacity: 1;
    }


    h1 {
        color: #FFF;
		text-transform: uppercase;
		font-size: 3rem;
		font-weight: 100;
	}


</style>