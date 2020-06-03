import React, {Fragment} from 'react';
import { Container, Grid, Advertisement, Segment } from 'semantic-ui-react'

import NavBar from '../../features/nav/NavBar';
import BreakingNews from '../articles/BreakingNews';
import FrontArticles from '../articles/FrontArticles';
import TopNews from '../articles/TopNews';
import SecondaryArticles from '../articles/SecondaryArticles';
import ScienceArticles from '../articles/ScienceArticles';
import Footer from '../nav/Footer';
import TechnologyArticles from '../articles/TechnologyArticles';


const HomePage = () => {
    

    return (
        <Fragment>
            <NavBar></NavBar>
            <Container>
                <BreakingNews />
                <FrontArticles />
                <TopNews />
                <Grid>
                    <Grid.Row columns={2} style={{marginTop: "5px"}}>
                        <Grid.Column width={11}>
                            <SecondaryArticles />
                        </Grid.Column>
                        <Grid.Column width={5}>
                            
                                <Segment>
                                    <Advertisement unit='half page' test='Half Page' />
                                </Segment>
                            
                           
                        </Grid.Column>

                    </Grid.Row>
                    <Grid.Row>
                        <Grid.Column width={11}>
                            <ScienceArticles />
                        </Grid.Column>
                        <Grid.Column width={5}>
                            <Segment>
                                <Advertisement unit='medium rectangle' test='Medium Rectangle' />
                            </Segment>
                        </Grid.Column>
                    </Grid.Row>
                    <Grid.Row>
                        <Grid.Column width={11}>
                            <TechnologyArticles />
                        </Grid.Column>
                        <Grid.Column width={5}>
                            <Segment>
                                <Advertisement unit='medium rectangle' test='Medium Rectangle' />
                            </Segment>
                        </Grid.Column>
                    </Grid.Row>

                </Grid>                
                
            </Container>
            <Footer />        

    </Fragment>
    )
    
}

export default HomePage
