<script>
  import { link } from "svelte-routing";
</script>

    <nav>
        <h1>The Projector</h1>
        <div>
            <ul>
                <li><a href="/projects" use:link>Add Project</a></li>
                <li><a href="/peoples" use:link>Add Person</a></li>
                <li><a href="/signout" class="btn btn--primary" style="color: #ff3e00" use:link>Log Out</a></li>
            </ul>
        </div>
        <!-- <div>
            <a href='/' class="btn" use:link>SIGN UP</a>
            <a href="login" class="btn btn--primary" use:link>LOGIN</a>
        </div> -->
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

    ul li a{
        color: #Fff;
        opacity: 0.8;
        transition: all .4s;
    }

    ul li a:hover{
        opacity: 1;
    }


    h1 {
        color: #FFF;
		text-transform: uppercase;
		font-size: 3rem;
		font-weight: 100;
	}


</style>