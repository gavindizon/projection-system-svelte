<script>
	import Navbar from './shared/Navbar.svelte';
	import {Route, Router} from "svelte-routing";
	import Login from "./pages/Login.svelte"; // home
	import Dashboard from "./pages/Dashboard.svelte"; // home
	import PeopleForm from './pages/PeopleForm.svelte';
	import ProjectForm from './pages/ProjectForm.svelte';
	export let url ="";

</script>


<Navbar/>
<br />
	<main>
		<Router url="{url}">
			<Route path="/" component="{Login}"/> 
			<Route path="/dashboard"><Dashboard/></Route>
			<Route path="/peoples"><PeopleForm/></Route>
			<Route path="/projects"><ProjectForm/></Route> 
		</Router>
	</main>

<style>
	main {
		text-align: center;
		padding: 1em;
		max-width: 240px;
		margin: 10rem auto;
	}

	@media (min-width: 640px) {
		main {
			max-width: none;
		}
	}
</style>