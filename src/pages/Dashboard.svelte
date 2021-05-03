<script>
import {link } from "svelte-routing";
import { authenticate } from "../helpers";
   const promise = authenticate();

//    window.location ="/";
</script>

{#await promise then data}
    <div style="margin: 0 3.2rem">
        <h3 style="text-align:left; ">Welcome, {data.first_name}!</h3>
        <br/>
        <table cellpadding="0" cellspacing="0">
            <tr>
                <th>Project Name</th>
                <th>Budget</th>
                <th>Tasks</th>
            </tr>       
            <tr>
                <td>Project Name</td>
                <td>$500m</td>
                <td><a href="projects/assignments/0" use:link>Tasks</a></td>
            </tr>        
            <tr>
                <td>Project Name</td>
                <td>$500m</td>
                <td><a href="projects/assignments/0" use:link>Tasks</a></td>
            </tr>        
            <tr>
                <td>Project Name</td>
                <td>$500m</td>
                <td><a href="projects/assignments/0" use:link>Tasks</a></td>
            </tr>
        </table>
    </div>    
{/await}

<style>
    table {border: none;}

    th, tr:first-of-type{
        background-color: #ff3e00;
        padding: 0.8rem 1.6rem;
        color: #FFF;
        text-transform: uppercase;
        font-size: 1.4rem;
}
td{
    padding: 0.8rem 1.6rem;
}
tr:nth-child(even){
    background-color: beige;
}
tr:nth-child(odd){
    background-color: azure;
}
</style>